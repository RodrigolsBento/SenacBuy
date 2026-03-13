using Microsoft.EntityFrameworkCore;
using SenacBuy.Domain.Entities;

namespace SenacBuy.Infrastructure.Data;

/// <summary>
/// DbContext principal da aplicação SenacBuy.
/// 
/// O DbContext é o "gerenciador" do Entity Framework Core.
/// Ele é responsável por:
/// 1. Abrir e fechar conexões com o banco de dados
/// 2. Rastrear alterações nas entidades
/// 3. Gerar e executar comandos SQL automaticamente
/// 4. Gerenciar transações
/// 
/// Esta classe pertence à Infrastructure, pois é um detalhe de implementação.
/// O Domain não conhece o DbContext - ele só conhece as interfaces.
/// </summary>
public class SenacBuyDbContext : DbContext
{
    /// <summary>
    /// Construtor que recebe as opções de configuração via injeção de dependência.
    /// As opções incluem a string de conexão que vem do appsettings.json.
    /// </summary>
    public SenacBuyDbContext(DbContextOptions<SenacBuyDbContext> options) : base(options)
    {
    }

    // DbSet representa cada tabela no banco de dados
    // O EF Core usará esses nomes para gerar as tabelas
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<ItemPedido> ItensPedido { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    /// <summary>
    /// Configuração do modelo de dados - relacionamentos, restrições, índices.
    /// É aqui que definimos as regras que o banco de dados deve respeitar.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // ========== CONFIGURAÇÃO DE USUARIO ==========
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Nome).IsRequired().HasMaxLength(100);
            entity.Property(u => u.Email).IsRequired().HasMaxLength(150);
            entity.Property(u => u.SenhaHash).IsRequired();

            // Índice único no Email - regra de negócio: email não pode se repetir
            entity.HasIndex(u => u.Email).IsUnique();
        });

        // ========== CONFIGURAÇÃO DE CLIENTE ==========
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            entity.Property(c => c.CPF).IsRequired().HasMaxLength(14);

            // Índice único no CPF - regra de negócio: CPF não pode se repetir
            entity.HasIndex(c => c.CPF).IsUnique();
        });

        // ========== CONFIGURAÇÃO DE CATEGORIA ==========
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Nome).IsRequired().HasMaxLength(100);
        });

        // ========== CONFIGURAÇÃO DE PRODUTO ==========
        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Nome).IsRequired().HasMaxLength(100);
            // decimal(18,2) significa até 18 dígitos no total e 2 casas decimais
            entity.Property(p => p.Preco).HasColumnType("decimal(18,2)");

            // Relacionamento: N Produtos → 1 Categoria (opcional)
            entity.HasOne(p => p.Categoria)
                  .WithMany(c => c.Produtos)
                  .HasForeignKey(p => p.CategoriaId)
                  .OnDelete(DeleteBehavior.SetNull);
        });

        // ========== CONFIGURAÇÃO DE PEDIDO ==========
        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Total).HasColumnType("decimal(18,2)");

            // Relacionamento: 1 Cliente -> N Pedidos
            // Se um cliente for deletado, seus pedidos são deletados também (Cascade)
            entity.HasOne(p => p.Cliente)
                  .WithMany(c => c.Pedidos)
                  .HasForeignKey(p => p.ClienteId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // ========== CONFIGURAÇÃO DE ITEM PEDIDO ==========
        modelBuilder.Entity<ItemPedido>(entity =>
        {
            entity.HasKey(ip => ip.Id);
            entity.Property(ip => ip.PrecoUnitario).HasColumnType("decimal(18,2)");

            // Relacionamento: 1 Pedido -> N ItensPedido
            entity.HasOne(ip => ip.Pedido)
                  .WithMany(p => p.Itens)
                  .HasForeignKey(ip => ip.PedidoId)
                  .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento: 1 Produto -> N ItensPedido
            // Restrict: não permite deletar um Produto que está em pedidos
            entity.HasOne(ip => ip.Produto)
                  .WithMany(p => p.ItensPedido)
                  .HasForeignKey(ip => ip.ProdutoId)
                  .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
