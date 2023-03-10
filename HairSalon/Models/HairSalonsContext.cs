using Microsoft.EntityFrameworkCore;

namespace HairSalons.Models
{
  public class HairSalonsContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public HairSalonsContext(DbContextOptions options) : base(options) { }
  }
}