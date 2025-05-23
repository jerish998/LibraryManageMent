using LibraryManagementSys.DbContextApp;
using LibraryManagementSys.Models;
using DTO;

namespace LibraryManagementSys.Services
{
    public class UserService 
    {
        #region const
        private readonly DbConnectionApp _db_connection_app;
        private readonly IUserService _user_service;
        #endregion

        public UserService(IUserService userService, DbConnectionApp dbConnectionApp) {
            _user_service = userService;
            _db_connection_app =  dbConnectionApp;
        }

        public  Task CreateUser(UserDto user_dto)
        {
            if (user_dto == null) {
                return ();
            }

            return Task.CompletedTask;

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
