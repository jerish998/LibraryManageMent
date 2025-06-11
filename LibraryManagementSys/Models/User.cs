namespace LibraryManagementSys.Models
{
    public class  User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

    }


    public class LoginModels
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
