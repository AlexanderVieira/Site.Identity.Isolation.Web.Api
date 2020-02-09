using Microsoft.AspNet.Identity.EntityFramework;
using SiteIdentityIsolation.Infra.Identity.Security.Models;
using System.Data.Entity;

namespace SiteIdentityIsolation.Infra.Identity.Security.ContextIdentity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ConnStrIdentity", throwIfV1Schema: false)
        {

        }

        public DbSet<Client> Client { get; set; }

        public DbSet<Claims> Claims { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}