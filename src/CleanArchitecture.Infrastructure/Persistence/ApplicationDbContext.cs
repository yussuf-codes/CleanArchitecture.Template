using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Model1> Entities1 { get; set; }
    public DbSet<Model2> Entities2 { get; set; }
    public DbSet<Model3> Entities3 { get; set; }
}
