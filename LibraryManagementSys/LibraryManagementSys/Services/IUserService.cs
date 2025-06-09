using DTO;
using System.Threading.Tasks;

namespace LibraryManagementSys.Services
{
    public interface IUserService
    {

        Task CreateUserAsync(UserDto user_dto);
        Task<List<UserDto>> FindUser(int id);
        Task UpdateUser();
        Task DeleteUser();

        Task<string> UserPing();
    }
}
