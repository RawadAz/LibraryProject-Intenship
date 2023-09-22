namespace ClassLibrary.Models.Employee
{
    public class Employee
    {
        public int? Id { get; set; }
        public string First_Name { get; set; } = string.Empty;
        public string Last_Name { get; set;} = string.Empty;
        public int Branch_Id { get; set; }
        public string Dob { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Phone_Number { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public double Salary { get; set; }
        public int? Supervisor_Id { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id &&
                   First_Name == employee.First_Name &&
                   Last_Name == employee.Last_Name &&
                   Branch_Id == employee.Branch_Id &&
                   Dob == employee.Dob &&
                   Gender == employee.Gender &&
                   Password == employee.Password &&
                   Phone_Number == employee.Phone_Number &&
                   Username == employee.Username &&
                   Position == employee.Position &&
                   Salary == employee.Salary &&
                   Supervisor_Id == employee.Supervisor_Id;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(First_Name);
            hash.Add(Last_Name);
            hash.Add(Branch_Id);
            hash.Add(Dob);
            hash.Add(Gender);
            hash.Add(Phone_Number);
            hash.Add(Username);
            hash.Add(Password);
            hash.Add(Position);
            hash.Add(Salary);
            hash.Add(Supervisor_Id);
            return hash.ToHashCode();
        }
    }
}
