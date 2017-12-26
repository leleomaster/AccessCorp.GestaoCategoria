using System.Web;
using System.Threading.Tasks;
using AccessCorp.GestaoCategoria.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Web.Http;
using AccessCorp.GestaoCategoria.Service.Interfaces;

namespace AccessCorp.GestaoCategoria.API.Controllers
{
    public class LoginController : ApiController
    {
        IAutenticacaoService _autenticacaoService;

        public LoginController(IAutenticacaoService autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;
        }

        public async Task<IHttpActionResult> Login(string userName, string password)
        {
            _autenticacaoService.IsValidUser(HttpContext.Current, userName, password);

            return Ok();
        }
    }
}
