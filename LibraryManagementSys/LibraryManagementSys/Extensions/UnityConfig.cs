using LibraryManagementSys.DbContextApp;
using LibraryManagementSys.Services;
using Unity;

namespace LibraryManagementSys.Extensions
{
    public static class UnityConfig
    {
        public static void RegisterServices(IUnityContainer container)
        {
            container.RegisterSingleton<IUserService, UserService>();

            container.RegisterType<IAuthProviderService, AuthProviderService>();
            
            
            //container.RegisterType<DbConnectionApp>();

            // 🔸 Add your other services here
        }
    }
}
