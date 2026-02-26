using MeraApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace MeraApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Country> Countries { get; set; }
    }
}
