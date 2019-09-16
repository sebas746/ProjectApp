using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;
using WebApi.App_Start;
using WebApp.DataAccess;
using WebApp.DataContext.WebApp;
using WebApp.Interfaces.DAC;
using WebApp.Interfaces.Service;
using WebApp.Services;


namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            // Web API configuration and services

            var container = new UnityContainer();

            //Register Account Dependencies
            var context = new WebAppDataContext();
            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<IAccountsDAC, AccountsDAC>();
            container.RegisterType<IPoliciesService, PoliciesService>();
            container.RegisterType<IPoliciesDAC, PoliciesDAC>();
            container.RegisterType<IClientService, ClientService>();
            container.RegisterType<IClientDAC, ClientsDAC>();
            container.RegisterType(typeof(IRepository<>), typeof(BaseRepository<>));


            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
