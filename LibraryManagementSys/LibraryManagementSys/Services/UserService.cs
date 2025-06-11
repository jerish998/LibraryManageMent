using LibraryManagementSys.DbContextApp;

using LibraryManagementSys.Models;
using DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;


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

        public  Task CreateUserAsync(User user)
        {
            if (user == null) {

                
                return Task.CompletedTask;

            }

            return Task.CompletedTask;


      
        }

        public async Task<List<UserDto>> FindUser(int id)
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
        public async Task<bool> UpdateUser(int user_id,UserDto user_dto)
        {
            var user = await _db_connection_app.Users.FindAsync(user_id);
            if (user == null)
                return false;

            user.UserName = user_dto.Name;
            user.Email = user_dto.Email;
            user.PasswordHash = user_dto.Password;
            await _db_connection_app.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteUser(int user_id)
        {
            var user = await _db_connection_app.Users.FindAsync(user_id);
            if (user == null)
                return false;

            _db_connection_app.Users.Remove(user);
            await _db_connection_app.SaveChangesAsync();
            return true;
        }


        public async Task<bool> UserExists(UserDto user_dto)
        {
            return await _db_connection_app.Users.AnyAsync(us => us.Email == user_dto.Email);
        }

       public   async Task<string> UserPing()
        {
            return await Task.FromResult("completed the USer Ping");
        }
    }
}
