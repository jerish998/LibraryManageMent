using LibraryManagementSys.DbContextApp;

using LibraryManagementSys.Models;
using DTO;


namespace LibraryManagementSys.Services
{
    public class UserService : IUserService
    {
        #region const

        private readonly DbConnectionApp _db_connection_app;
        
        #endregion

        //public UserService(DbConnectionApp dbConnectionApp) {
           
        //    _db_connection_app =  dbConnectionApp;
        //}
        public UserService()
        {
        }

        public  Task CreateUserAsync(UserDto user_dto)
        {
            if (user_dto == null) {

                
                return Task.CompletedTask;

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

       public   async Task<string> UserPing()
        {
            return await Task.FromResult("completed the USer Ping");
        }
    }
}
