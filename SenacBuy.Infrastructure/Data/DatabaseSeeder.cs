using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SenacBuy.Domain.Entities;

namespace SenacBuy.Infrastructure.Data;

/// <summary>
/// Responsável por popular o banco de dados com dados iniciais de teste.
///
/// O seed só é executado se as tabelas estiverem vazias, garantindo
/// que não há duplicação de dados em execuções subsequentes.
///
/// Como usar:
///   await DatabaseSeeder.SeedAsync(dbContext);
///
/// Chamado no Program.cs da API logo após garantir que o banco existe.
/// </summary>
public static class DatabaseSeeder
{
    /// <summary>
    /// Ponto de entrada principal do seed.
    /// Verifica cada tabela e insere dados apenas se estiver vazia.
    /// </summary>
    public static async Task SeedAsync(SenacBuyDbContext db)
    {
        // Aplica migrations pendentes e garante que o banco existe
        await db.Database.MigrateAsync();

        // A ordem importa: seed na ordem das dependências (FK)
        await SeedUsuariosAsync(db);
        await SeedClientesAsync(db);
        await SeedCategoriasAsync(db);
        await SeedProdutosAsync(db);
        await SeedPedidosAsync(db);
    }

    // ──────────────────────────────────────────────────────────────────────────────
    // USUÁRIOS
    // ──────────────────────────────────────────────────────────────────────────────

    private static async Task SeedUsuariosAsync(SenacBuyDbContext db)
    {
        // Só insere se a tabela estiver vazia
        if (await db.Usuarios.AnyAsync()) return;

        // Senha "1234" para todos os usuários de teste
        // (GerarHash replica o algoritmo do UsuarioService)
        var hash1234 = GerarHash("1234");

        db.Usuarios.AddRange(
            new Usuario { Nome = "Administrador",    Email = "admin@senac.br",   SenhaHash = hash1234 },
            new Usuario { Nome = "João Silva",       Email = "joao@senac.br",    SenhaHash = GerarHash("joao123") },
            new Usuario { Nome = "Maria Oliveira",   Email = "maria@senac.br",   SenhaHash = GerarHash("maria123") },
            new Usuario { Nome = "Carlos Souza",     Email = "carlos@senac.br",  SenhaHash = GerarHash("carlos123") },
            new Usuario { Nome = "Ana Lima",         Email = "ana@senac.br",     SenhaHash = GerarHash("ana123") }
        );

        await db.SaveChangesAsync();
        Console.WriteLine("✅ Seed: 5 usuários inseridos.");
    }

    // ──────────────────────────────────────────────────────────────────────────────
    // CLIENTES
    // ──────────────────────────────────────────────────────────────────────────────

    private static async Task SeedClientesAsync(SenacBuyDbContext db)
    {
        if (await db.Clientes.AnyAsync()) return;

        db.Clientes.AddRange(
            new Cliente { Nome = "Ana Paula Souza",      CPF = "111.222.333-01" },
            new Cliente { Nome = "Carlos Mendes",        CPF = "111.222.333-02" },
            new Cliente { Nome = "Fernanda Lima",        CPF = "111.222.333-03" },
            new Cliente { Nome = "Roberto Alves",        CPF = "111.222.333-04" },
            new Cliente { Nome = "Juliana Nascimento",   CPF = "111.222.333-05" },
            new Cliente { Nome = "Lucas Ferreira",       CPF = "111.222.333-06" },
            new Cliente { Nome = "Beatriz Santos",       CPF = "111.222.333-07" },
            new Cliente { Nome = "Rodrigo Costa",        CPF = "111.222.333-08" },
            new Cliente { Nome = "Tatiane Ribeiro",      CPF = "111.222.333-09" },
            new Cliente { Nome = "Eduardo Melo",         CPF = "111.222.333-10" }
        );

        await db.SaveChangesAsync();
        Console.WriteLine("✅ Seed: 10 clientes inseridos.");
    }

    // ──────────────────────────────────────────────────────────────────────────────
    // CATEGORIAS
    // ──────────────────────────────────────────────────────────────────────────────

    private static async Task SeedCategoriasAsync(SenacBuyDbContext db)
    {
        if (await db.Categorias.AnyAsync()) return;

        db.Categorias.AddRange(
            new Categoria { Nome = "Eletrônicos" },
            new Categoria { Nome = "Periféricos" },
            new Categoria { Nome = "Monitores" },
            new Categoria { Nome = "Impressoras" },
            new Categoria { Nome = "Armazenamento" },
            new Categoria { Nome = "Acessórios" }
        );

        await db.SaveChangesAsync();
        Console.WriteLine("✅ Seed: 6 categorias inseridas.");
    }

    // ──────────────────────────────────────────────────────────────────────────────
    // PRODUTOS
    // ──────────────────────────────────────────────────────────────────────────────

    private static async Task SeedProdutosAsync(SenacBuyDbContext db)
    {
        if (await db.Produtos.AnyAsync()) return;

        // Busca categorias para atribuir aos produtos
        var categorias = await db.Categorias.ToListAsync();
        int CatId(string nome) => categorias.First(c => c.Nome == nome).Id;

        db.Produtos.AddRange(
            // Eletrônicos
            new Produto { Nome = "Notebook Dell Inspiron 15",   Preco = 4500.00m, CategoriaId = CatId("Eletrônicos") },
            new Produto { Nome = "Notebook Samsung Book",       Preco = 3200.00m, CategoriaId = CatId("Eletrônicos") },
            new Produto { Nome = "MacBook Air M2",              Preco = 9800.00m, CategoriaId = CatId("Eletrônicos") },
            new Produto { Nome = "Ultrabook Lenovo ThinkPad",   Preco = 5400.00m, CategoriaId = CatId("Eletrônicos") },
            // Periféricos
            new Produto { Nome = "Mouse Logitech MX Master 3",  Preco = 350.00m,  CategoriaId = CatId("Periféricos") },
            new Produto { Nome = "Mouse Gamer Razer DeathAdder",Preco = 280.00m,  CategoriaId = CatId("Periféricos") },
            new Produto { Nome = "Teclado Mecânico HyperX",     Preco = 420.00m,  CategoriaId = CatId("Periféricos") },
            new Produto { Nome = "Teclado Logitech MX Keys",    Preco = 560.00m,  CategoriaId = CatId("Periféricos") },
            new Produto { Nome = "Headset JBL Quantum",         Preco = 390.00m,  CategoriaId = CatId("Periféricos") },
            new Produto { Nome = "Webcam Logitech C920",        Preco = 480.00m,  CategoriaId = CatId("Periféricos") },
            // Monitores
            new Produto { Nome = "Monitor LG Ultrawide 29\"",   Preco = 2100.00m, CategoriaId = CatId("Monitores") },
            new Produto { Nome = "Monitor Dell 27\" 4K",        Preco = 3400.00m, CategoriaId = CatId("Monitores") },
            new Produto { Nome = "Monitor Samsung 24\" FHD",    Preco = 1200.00m, CategoriaId = CatId("Monitores") },
            // Impressoras
            new Produto { Nome = "Impressora HP LaserJet",      Preco = 980.00m,  CategoriaId = CatId("Impressoras") },
            new Produto { Nome = "Impressora Epson EcoTank",    Preco = 1350.00m, CategoriaId = CatId("Impressoras") },
            // Armazenamento
            new Produto { Nome = "SSD Kingston 1TB NVMe",       Preco = 420.00m,  CategoriaId = CatId("Armazenamento") },
            new Produto { Nome = "HD Externo Seagate 2TB",      Preco = 360.00m,  CategoriaId = CatId("Armazenamento") },
            new Produto { Nome = "Pen Drive Sandisk 64GB",      Preco = 60.00m,   CategoriaId = CatId("Armazenamento") },
            // Acessórios
            new Produto { Nome = "Suporte Ergonômico Notebook", Preco = 180.00m,  CategoriaId = CatId("Acessórios") },
            new Produto { Nome = "Hub USB-C 7 Portas",          Preco = 140.00m,  CategoriaId = CatId("Acessórios") }
        );

        await db.SaveChangesAsync();
        Console.WriteLine("✅ Seed: 20 produtos inseridos.");
    }

    // ──────────────────────────────────────────────────────────────────────────────
    // PEDIDOS
    // ──────────────────────────────────────────────────────────────────────────────

    private static async Task SeedPedidosAsync(SenacBuyDbContext db)
    {
        if (await db.Pedidos.AnyAsync()) return;

        // Busca os IDs gerados pelo banco após o seed de clientes e produtos
        var clientes = await db.Clientes.ToListAsync();
        var produtos  = await db.Produtos.ToListAsync();

        if (clientes.Count < 5 || produtos.Count < 5)
        {
            Console.WriteLine("⚠️  Seed de pedidos ignorado: clientes ou produtos insuficientes.");
            return;
        }

        // Pedidos com datas variadas para simular histórico
        // Status: Pendente, Finalizado, Cancelado
        var base_ = new DateTime(2026, 3, 1);

        var pedidos = new List<(int clienteIndex, DateTime data, string status, List<(int prodIdx, int qty)> itens)>
        {
            (0, base_,            "Finalizado",  new() { (0, 1), (4, 2) }),
            (1, base_.AddDays(1), "Finalizado",  new() { (6, 1), (7, 1) }),
            (2, base_.AddDays(2), "Pendente",    new() { (10, 1) }),
            (3, base_.AddDays(2), "Finalizado",  new() { (13, 1), (15, 2) }),
            (4, base_.AddDays(3), "Pendente",    new() { (4, 1), (8, 1), (18, 1) }),
            (5, base_.AddDays(4), "Finalizado",  new() { (2, 1) }),
            (6, base_.AddDays(5), "Cancelado",   new() { (11, 1), (5, 1) }),
            (7, base_.AddDays(6), "Pendente",    new() { (3, 1), (9, 1) }),
            (8, base_.AddDays(7), "Finalizado",  new() { (16, 2), (17, 5) }),
            (0, base_.AddDays(8), "Cancelado",   new() { (19, 2), (14, 1) }),
        };

        foreach (var (clienteIdx, data, status, listaItens) in pedidos)
        {
            var pedido = new Pedido
            {
                ClienteId  = clientes[clienteIdx].Id,
                DataPedido = data,
                Status     = status,
                Total      = 0
            };

            foreach (var (prodIdx, qty) in listaItens)
            {
                var prod = produtos[prodIdx];
                pedido.Itens.Add(new ItemPedido
                {
                    ProdutoId     = prod.Id,
                    Quantidade    = qty,
                    PrecoUnitario = prod.Preco
                });
            }

            pedido.RecalcularTotal();
            db.Pedidos.Add(pedido);
        }

        await db.SaveChangesAsync();
        Console.WriteLine("✅ Seed: 10 pedidos inseridos (Pendente/Finalizado/Cancelado).");
    }

    // ──────────────────────────────────────────────────────────────────────────────
    // AUXILIAR: hash SHA256 igual ao UsuarioService
    // ──────────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Replica o GerarHash do UsuarioService para que as senhas do seed
    /// sejam válidas no login. Não usar em produção — use BCrypt.
    /// </summary>
    private static string GerarHash(string texto)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(texto));
        return Convert.ToHexString(bytes).ToLower();
    }
}
