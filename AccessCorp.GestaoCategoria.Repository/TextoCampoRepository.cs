using AccessCorp.GestaoCategoria.Domain;
using AccessCorp.GestaoCategoria.EntityFramework;
using AccessCorp.GestaoCategoria.EntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Repository
{
    public class TextoCampoRepository : DbContextAccessCorp<TextoCampo>, IUnitOfWork<TextoCampo>
    {
    }
}
