using SimpleInjector;
using StudentManagementSystem.DI;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StudentManagementSystem
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<EntityModel.StudentContext>(null);
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
                       
            //DI registration integration to WebApi
            var container = new Container();
            Bootstrap.Container = container;
            Bootstrap.RegisterTypes(container);
            GlobalConfiguration.Configuration.DependencyResolver = Bootstrap.Resolver(container);
            container.Verify();

        }
    }
}
