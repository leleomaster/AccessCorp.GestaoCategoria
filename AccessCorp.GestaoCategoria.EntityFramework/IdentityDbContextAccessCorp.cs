using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework
{
    public class IdentityDbContextAccessCorp : IdentityDbContext<Usuario>
    {
        public IdentityDbContextAccessCorp()
              : base("EFConnectionStringAccessCorp")
        { }

        public static IdentityDbContextAccessCorp Create()
        {
            return new IdentityDbContextAccessCorp();
        }
    }
}
