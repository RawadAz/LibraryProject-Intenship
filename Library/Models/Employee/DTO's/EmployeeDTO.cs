namespace Library.Models.Employee.DTO_s
{
    public class EmployeeDTO
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

        public string Position { get; set; } = string.Empty;

        public double Salary { get; set; }

        public int? Supervisor_Id { get; set; }

    }
}
