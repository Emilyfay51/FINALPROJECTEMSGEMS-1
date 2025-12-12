using Microsoft.EntityFrameworkCore;
using FinalProjectEmsGems_1.Models; // Ensure this is the correct namespace for Review

namespace FinalProjectEmsGems_1.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    public DbSet<Product> Products {get; set;}
    public DbSet<Review> Reviews {get; set;}
}