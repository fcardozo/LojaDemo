using Microsoft.Practices.Unity;
using Infrastructure.CrossCutting.IoC.Core.Unity;
using LojaDemo.Application.Repository;
using LojaDemo.Application.UserApplication;

namespace LojaDemo.Infrastructure.Ioc.Container
{
    public class RootContainer : IoCUnityContainer
    {
        public override void ConfigureRealContainer(IUnityContainer container)
        {
            /// Register Application mappings
            container.RegisterType<IUserApplicationService, UserApplicationService>(new TransientLifetimeManager());

            /// Register Repository mappings
            container.RegisterType<IUserRepository, Repository.UserRepository>(new TransientLifetimeManager());

        }

        public override void ConfigureFakeContainer(IUnityContainer container)
        {
            
        }
    }
}
