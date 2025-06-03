using LibraryManagementSys.DbContextApp;

using LibraryManagementSys.Models;
using DTO;
using Microsoft.AspNetCore.Http.HttpResults;


namespace LibraryManagementSys.Services
{
    public class UserService : IUserService
    {
        #region const

        private readonly DbConnectionAppContext _db_connection_app;
        
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

        public async Task<Iemmurable> FindUser(int id)
        {
          return _db_connection_app.Users
                .Select(u => new UserDto
                {
                    Id = u.UserId,
                    Name = u.UserName,
                    Email = u.Email
                })
                .ToList();
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
