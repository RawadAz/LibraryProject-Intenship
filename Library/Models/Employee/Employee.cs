using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.AccessControl;

namespace Library.Models.Employee
{
    public class Employee
    {
        public int Id { get; set; }

        public string First_Name { get; set; } = string.Empty;

        public string Last_Name { get; set; } = string.Empty;

        public int Branch_Id { get; set; }

        private string dob = string.Empty;

        public string Dob
        {
            get
            {
                bool conversion = DateOnly.TryParseExact(dob, "MM/dd/yyyy hh:mm:ss", out DateOnly dateOnly);
                if (conversion)
                    dob = dateOnly.ToString();
                return dob;
            }
            set { dob = value; }
        }

        public string Gender { get; set; } = string.Empty;

        public string Phone_Number { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty;

        public double Salary { get; set; }

        public int? Supervisor_Id { get; set; }

    }
}
