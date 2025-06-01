using LibraryManagementSys.DbContextApp;
using LibraryManagementSys.Services;
using System.ComponentModel;
using System.Xml.Linq;
using Unity;

namespace LibraryManagementSys._Factories
{
    public static class LibManUnityContainerFactory
    {
        
       

        public static void RegisterDependencies(IUnityContainer container)
        {
            //container.RegisterInstance(this);
            container.RegisterType<IAuthProviderService, AuthProviderService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<DbConnectionApp>();

        }




    }
}
