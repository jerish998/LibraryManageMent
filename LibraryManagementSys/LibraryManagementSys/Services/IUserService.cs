﻿using DTO;
using LibraryManagementSys.Models;
using System.Threading.Tasks;

namespace LibraryManagementSys.Services
{
    public interface IUserService
    {

        Task CreateUserAsync(User user);
        Task<List<UserDto>> FindUser(int id);
        Task<bool> UpdateUser(int user_id, UserDto user_dto);
        Task<bool> DeleteUser(int id);
         Task<bool> UserExists(UserDto user_dto);

        Task<string> UserPing();
    }
}
