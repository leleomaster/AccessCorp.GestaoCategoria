using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework
{
    public class Usuario : IdentityUser
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
    }
}
