using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework
{
    public class AppSignInManager : SignInManager<Usuario, string>
    {
        public AppSignInManager(UsuarioAppManager userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager)
        {

        }

        public static AppSignInManager Create(IdentityFactoryOptions<AppSignInManager> option, IOwinContext context)
        {
            var manager = context.GetUserManager<UsuarioAppManager>();

            var sign = new AppSignInManager(manager, context.Authentication);

            return sign;
        }
    }
}
