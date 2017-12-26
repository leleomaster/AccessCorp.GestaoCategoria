using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework
{
    public class UsuarioAppManager : UserManager<Usuario>
    {
        public UsuarioAppManager(IUserStore<Usuario> store) : base(store)
        {
        }

        public static UsuarioAppManager Create(IdentityFactoryOptions<UsuarioAppManager> options, IOwinContext context)
        {
            var appcontext = context.Get<IdentityDbContextAccessCorp>();

            var usuarioManager = new UsuarioAppManager(new UserStore<Usuario>(appcontext));

            return usuarioManager;
        }
    }
}
