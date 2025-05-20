namespace LibraryManagementSys.Services
{
    public interface IUserService
    {
        Task CreateUser();
        Task FindUser();
        Task UpdateUser();
        Task DeleteUser();


    }
}
