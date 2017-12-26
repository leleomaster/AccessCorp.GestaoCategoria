using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AccessCorp.GestaoCategoria.EntityFramework.Interfaces
{
    public interface IAutenticacaoRepository
    {
        Task<bool> IsValidUser(HttpContext context, string userName, string password);
    }
}
