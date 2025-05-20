using LibraryManagementSys.DbContextApp;

namespace LibraryManagementSys.Services
{
    public class UserService 
    {
        #region const
        private readonly DbConnectionApp db_connection_app;
        private readonly IUserService _user_service;
        #endregion

        public UserService(IUserService userService) {
            _user_service = userService;
        }

        public async Task CreateUser(User)
        {
            
        }

        public async Task FindUser()
        {

        }
        public async Task UpdateUser()
        {

        }
        public async Task DeleteUser()
        {

        }
    }
}
