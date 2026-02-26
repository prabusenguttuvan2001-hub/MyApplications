using Microsoft.EntityFrameworkCore;
using Sample_CRUD_for_Verisk.Entities;

namespace Sample_CRUD_for_Verisk.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Roles> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Vendor>()
                .HasOne<Roles>()
                .WithMany()
                .HasForeignKey(v => v.Role_id)
                .OnDelete(DeleteBehavior.Cascade);
           
        }
    }
}
