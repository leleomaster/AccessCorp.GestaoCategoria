using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace AccessCorp.GestaoCategoria.API.Security
{
    public class ClaimsAuthorizeAttribute : AuthorizeAttribute
    {
        public ClaimsAuthorizeAttribute() { }
        
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext filterContext)
        {
            var user = HttpContext.Current.User as ClaimsPrincipal;

            if (user.Claims.Where(c => c.Type == ClaimTypes.Country)
                .Any(x => x.Value == "Brasil")
                && user.IsInRole("Administrador"))
            {
                base.OnAuthorization(filterContext);
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}