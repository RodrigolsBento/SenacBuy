using Microsoft.EntityFrameworkCore;
using SenacBuy.Domain.Entities;
namespace SenacBuy.Infrastructure.Data;

public class SenacBuyDbContext : DbContext
{

    public SenacBuyDbContext(DbContextOptions<SenacBuyDbContext> options) : base(options)
    {
    }

    //classe que ira se referir e o nome da tabela no banco de dados, ou seja, a classe que representa a tabela no banco de dados, ou seja, a classe que representa a entidade no banco de dados, ou seja, a classe que representa o modelo no banco de dados, ou seja, a classe que representa o objeto no banco de dados, ou seja, a classe que representa o recurso no banco de dados, ou seja, a classe que representa o domínio no banco de dados.
    public DbSet<Usuario> Usuarios { get; set; } //Usuario representa a tabela de usuários no banco de dados, ou seja, a entidade de usuários no banco de dados, ou seja, o modelo de usuários no banco de dados, ou seja, o objeto de usuários no banco de dados, ou seja, o recurso de usuários no banco de dados, ou seja, o domínio de usuários no banco de dados todos .

    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Produto> Produtos { get; set; }

    public DbSet<Pedido> Pedidos { get; set; }

    public DbSet<ItemPedido> ItensPedido { get; set; }

    

    //falar como será a criação, caracter, obrigatório não é .... Regras do banco de dados 
    protected override void OnModelCreating(ModelBuilder modelBuilder) /// o metado diz o modo de como será creado
    {
        base.OnModelCreating(modelBuilder);

        //config usuario
        modelBuilder.Entity<Usuario>(entity =>
        {
            //a chave do usuário será uma propriedade do usuário chamado ID
            entity.HasKey(usuario => usuario.Id); //chave primária
            entity.Property (usuario => usuario.Nome) .IsRequired () .HasMaxLength (100);
            entity.Property (usuario => usuario.Email) .IsRequired () .HasMaxLength (100);
            entity.Property (usuario => usuario.SenhaHash) .IsRequired () .HasMaxLength (100);

            entity.HasIndex(usuario => usuario.Email).IsUnique(); //garante que o email seja único no banco de dados, ou seja, não pode haver dois usuários com o mesmo email no banco de dados, ou seja, o email é um campo único no banco de dados, ou seja, o email é um campo de identificação no banco de dados, ou seja, o email é um campo de autenticação no banco de dados, ou seja, o email é um campo de autorização no banco de dados.
        });

    }

}
