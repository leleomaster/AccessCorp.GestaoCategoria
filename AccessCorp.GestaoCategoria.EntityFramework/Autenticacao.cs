using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using AccessCorp.GestaoCategoria.EntityFramework;
using AccessCorp.GestaoCategoria.EntityFramework.Interfaces;

namespace AccessCorp.GestaoCategoria.EntityFramework
{
    public class Autenticacao : IAutenticacaoRepository
    {
        public async Task<bool> IsValidUser(HttpContext context, string userName, string password)
        {
            var userManager = context.GetOwinContext().GetUserManager<UsuarioAppManager>();

            var user = await userManager.FindAsync(userName, password);

            var appAsign = context.GetOwinContext().Get<AppSignInManager>();

            appAsign.SignIn(user, true, true);

            return true;
        }
    }
}
