namespace ClassLibrary.Models.Employee.DTO_s
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string First_Name { get; set; } = string.Empty;
        public string Last_Name { get; set; } = string.Empty;
        public int Branch_Id { get; set; }
        public string Dob { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Phone_Number { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public double Salary { get; set; }
        public int? Supervisor_Id { get; set; }
    }
}
