[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TestWebApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(TestWebApi.App_Start.NinjectWebCommon), "Stop")]

namespace TestWebApi.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using AutoMapper;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Ninject.Web.WebApi;
    using TestWebApi.Core.Logic;
    using TestWebApi.Core.Model;

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
                var mapperConfig = CreateConfiguration();

                kernel.Bind<MapperConfiguration>().ToConstant(mapperConfig).InSingletonScope();
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IMapper>().ToMethod(ctx => new Mapper(mapperConfig, type => ctx.Kernel.Get(type)));
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);

                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
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
            kernel.Bind<UserManager>().ToSelf();
            kernel.Bind<SubscriptionManager>().ToSelf();
        }

        private static MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, Models.User>();
                cfg.CreateMap<Subscription, Models.Subscription>();
                cfg.CreateMap<Models.User, User>();
                cfg.CreateMap<Models.Subscription, Subscription>();

                cfg.CreateMap<User, Core.TestDbServiceReference.User>();
                cfg.CreateMap<Subscription, Core.TestDbServiceReference.Subscription>();
                cfg.CreateMap<Core.TestDbServiceReference.User, User>();
                cfg.CreateMap<Core.TestDbServiceReference.Subscription, Subscription>();
            });

            return config;
        }
    }
}