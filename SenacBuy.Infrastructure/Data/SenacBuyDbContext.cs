using Microsoft.EntityFrameworkCore;
namespace SenacBuy.Infrastructure.Data;

public class SenacBuyDbContext : DbContext
{

    public SenacBuyDbContext(DbContextOptions<SenacBuyDbContext> options) : base(options)
    {
    }

    



}
