using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Client
{
    public class Client
    {
        public int Id { get; set; }

        public string First_Name { get; set; } = string.Empty;

        public string Last_Name { get; set; } = string.Empty;

        public string Phone_Number { get; set; } = string.Empty;

        public int Currently_Rented { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Client client &&
                   Id == client.Id &&
                   First_Name == client.First_Name &&
                   Last_Name == client.Last_Name &&
                   Phone_Number == client.Phone_Number &&
                   Currently_Rented == client.Currently_Rented;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, First_Name, Last_Name, Phone_Number, Currently_Rented);
        }
    }
}
