using Unity;

namespace LibraryManagementSys._Factories
{
    public class LibManUnityContainerFactory
    {
        private IUnityContainer _container;
        public LibManUnityContainerFactory(IUnityContainer container)
        {

            _container = new UnityContainer();
            _container = container;
        }

        public void RegisterDependencies(IUnityContainer container)
        {
            container.RegisterInstance(this);
        }




    }
}
