using System;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;

namespace SmartMvc.Admin.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new DecimalConverter());
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new BooleanConverter());
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new DateConverter());
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            GlobalConfiguration.Configuration.Services.Insert(typeof(ModelBinderProvider), 0, new BinderProvider());
            GlobalConfiguration.Configuration.SuppressDefaultHostAuthentication();
            GlobalConfiguration.Configuration.Filters.Add(new HostAuthenticationFilter(DefaultAuthenticationTypes.ApplicationCookie));
            GlobalConfiguration.Configuration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Services.Replace(typeof(IHttpControllerSelector), new AreaHttpControllerSelector(config));

        }
    }
}