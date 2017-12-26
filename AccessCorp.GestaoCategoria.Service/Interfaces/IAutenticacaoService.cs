using AccessCorp.GestaoCategoria.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AccessCorp.GestaoCategoria.Service.Interfaces
{
    public interface IAutenticacaoService
    {
        bool IsValidUser(HttpContext context, string userName, string password);
    }
}
