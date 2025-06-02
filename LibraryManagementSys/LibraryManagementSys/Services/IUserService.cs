using DTO;

namespace LibraryManagementSys.Services
{
    public interface IUserService
    {

        Task CreateUserAsync(UserDto user_dto);

        Task FindUser(int id);
        Task UpdateUser();
        Task DeleteUser();

        Task<string> UserPing();
    }
}
