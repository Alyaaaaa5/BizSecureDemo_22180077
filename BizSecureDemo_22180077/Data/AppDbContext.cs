using Microsoft.EntityFrameworkCore;
using BizSecureDemo_22180077.Models;
namespace BizSecureDemo_22180077.Data;
public class AppDbContext : DbContext
{
    public DbSet<Users> Users => Set<Users>();
    public DbSet<Orders> Orders => Set<Orders>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
