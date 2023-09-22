using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Employee.DTO_s.LoginInfo
{
    public class LoginInfoResponseDTO
    {
        public string First_Name { get; set; } = string.Empty;
        public string Last_Name { get; set;} = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string? Token { get; set;}
    }
}
