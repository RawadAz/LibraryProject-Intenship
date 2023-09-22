namespace Library.Models.Employee
{
    public class LoginInfoDTO
    {
        public string First_Name { get; set; } = string.Empty;
        public string Last_Name { get; set;} = string.Empty;
        public string Position { get; set;} = string.Empty;
        public string? Token { get; set;} = string.Empty;
    }
}
