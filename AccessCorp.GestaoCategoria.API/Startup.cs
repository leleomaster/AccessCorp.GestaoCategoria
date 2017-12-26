using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using AccessCorp.GestaoCategoria.API.Providers;
using AccessCorp.GestaoCategoria.EntityFramework;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(AccessCorp.GestaoCategoria.API.Startup))]

namespace AccessCorp.GestaoCategoria.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();

            ConfigureRotas(configuration);

            app.CreatePerOwinContext(IdentityDbContextAccessCorp.Create);
            app.CreatePerOwinContext<UsuarioAppManager>(UsuarioAppManager.Create);
            app.CreatePerOwinContext<AppSignInManager>(AppSignInManager.Create);

            var oAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,                               // Se True permite requisições Http não seguras, caso contrário, aceita apenas requisições seguras;
                TokenEndpointPath = new PathString("/api/login"),       // URL aonde o cliente irá solicitar o Token;
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1),      // duração do Token;
                Provider = new AccessCorpAuthorizationServerProvider()  // Classe que criará o Token dinamicamente.
            };

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                CookieName = "Devimedia",
                CookiePath = "/"
            });

            app.UseOAuthAuthorizationServer(oAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
            app.UseWebApi(configuration);            
        }
        private static void ConfigureRotas(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );
        }

    }
}
