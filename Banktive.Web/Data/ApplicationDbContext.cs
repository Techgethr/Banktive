using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Banktive.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}