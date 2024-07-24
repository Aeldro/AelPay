using Microsoft.EntityFrameworkCore;
using WildPay.Models.Entities;

namespace AelPay.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
