using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;
using SiteIdentityIsolation.Infra.Identity.Security.ContextIdentity;
using SiteIdentityIsolation.Infra.Identity.Security.Identity;
using SiteIdentityIsolation.Infra.Identity.Security.Models;

namespace SiteIdentityIsolation.Infra.CrossCuting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.RegisterPerWebRequest<ApplicationDbContext>();
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.RegisterPerWebRequest<ApplicationRoleManager>();
            container.RegisterPerWebRequest<ApplicationUserManager>();
            container.RegisterPerWebRequest<ApplicationSignInManager>();

            //container.RegisterPerWebRequest<IUsuarioRepository, UsuarioRepository>();
        }
    }
}