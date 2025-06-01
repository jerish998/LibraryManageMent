namespace LibraryManagementSys.Services
{
    public interface IAuthProviderService
    {
        public string GenerateJwtToken(string username);
    }
}
