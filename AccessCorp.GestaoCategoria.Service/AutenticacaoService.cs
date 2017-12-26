using AccessCorp.GestaoCategoria.EntityFramework.Interfaces;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System.Web;

namespace AccessCorp.GestaoCategoria.Service
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly IAutenticacaoRepository _autenticacaoRepository;

        public AutenticacaoService(IAutenticacaoRepository autenticacaoRepository)
        {
            _autenticacaoRepository = autenticacaoRepository;
        }

        public bool IsValidUser(HttpContext context, string userName, string password)
        {
            return _autenticacaoRepository.IsValidUser(context, userName, password).Result;
        }
    }
}
