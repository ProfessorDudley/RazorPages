using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Data
{
  public class ComputerContext : DbContext
  {
    public ComputerContext(DbContextOptions<ComputerContext> options) : base(options)
    {

    }
    public DbSet<Computer> Computers  { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Computer>().ToTable("Computer");
    }
  }
}