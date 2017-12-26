using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Threading;

namespace AccessCorp.GestaoCategoria.Autentication
{    
    public class Autentication
    {
        private IList<Claim> claims = null;

        public Autentication()
        {
            claims = new List<Claim>();
        }
        
        public void CriandoIdentidade()
        {
            Claim c = new Claim(null);

            Claim claim2 = new Claim(ClaimTypes.Name, "Fabio Rodrigues Fonseca");
            Claim claim3 = new Claim(ClaimTypes.Role, "Administrador");
            Claim claim4 = new Claim(ClaimTypes.Email, "fabison@ig.com.br");

            claims.Add(claim2);
            claims.Add(claim3);
            claims.Add(claim4);

            //Criando uma Identidade e associando-a ao ambiente.
            ClaimsIdentity identity = new ClaimsIdentity(claims);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            Thread.CurrentPrincipal = principal;

            //Definindo as roles e o nome da Identidade
            //Criando uma Identidade e associando-a ao ambiente.
            ClaimsIdentity identity2 = new ClaimsIdentity(claims, "AccessCorp", ClaimTypes.Email, ClaimTypes.Role);

            ClaimsPrincipal principal2 = new ClaimsPrincipal(identity2);
            Thread.CurrentPrincipal = principal2;
        }

        public void AutenciandoUsuario()
        {
            ClaimsIdentity identity = new ClaimsIdentity(claims, "AccessCorp");
        }


    }
}
