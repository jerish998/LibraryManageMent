using LibraryManagementSys.Services;
using Unity;

namespace LibraryManagementSys._Factories
{
    public class LibManUnityContainerFactory
    {
        private IUnityContainer _container;
        public LibManUnityContainerFactory(IUnityContainer container)
        {

            
            _container = container;
            RegisterDependencies(_container);
            
        }

        public void RegisterDependencies(IUnityContainer conatiner)
        {
            //container.RegisterInstance(this);
            conatiner.RegisterType<IAuthProviderService, AuthProviderService>();

            
        }




    }
}
