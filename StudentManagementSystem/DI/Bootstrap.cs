using Business;
using Business.Services;
using DataAccess;
using DataAccess.DataService;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using StudentManagementSystem.Controllers;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http.Dependencies;

namespace StudentManagementSystem.DI
{

    public static class Bootstrap
    {
        public static Container Container { get; set; }

        public static void RegisterTypes(Container container)
        {
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            container.Register<IStudentService, StudentService>();
            container.Register<IStudentDataService, StudentDataService>();
        }

        public static IDependencyResolver Resolver(Container container)
        {
            return new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}