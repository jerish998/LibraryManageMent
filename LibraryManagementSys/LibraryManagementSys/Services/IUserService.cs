namespace LibraryManagementSys.Services
{
    public interface IUserService
    {

        Task CreateUserAsync();

        Task FindUser();
        Task UpdateUser();
        Task DeleteUser();


    }
}
