[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProjetoAlarme.Presentation.Web.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ProjetoAlarme.Presentation.Web.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace ProjetoAlarme.Presentation.Web.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using ProjetoAlarme.Application.Interface;
    using ProjetoAlarme.Application.Service;
    using ProjetoAlarme.Domain.Interface.Repositorys;
    using ProjetoAlarme.Domain.Interface.Services;
    using ProjetoAlarme.Domain.Service;
    using ProjetoAlarme.Infra.Data.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(AppServiceBase<>)).To(typeof(IAppServiceBase<>));

            kernel.Bind(typeof(ServiceBase<>)).To(typeof(IServiceBase<>));
            
            kernel.Bind(typeof(RepositoryBase<>)).To(typeof(IRepositorysBase<>));
        }        
    }
}
