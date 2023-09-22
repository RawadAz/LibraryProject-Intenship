using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Branch
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int? Manager_Id { get; set; }
        public string? Manager_Start_Date { get; set; } = string.Empty;

        public override bool Equals(object? obj)
        {
            return obj is Branch branch &&
                   Id == branch.Id &&
                   Name == branch.Name &&
                   Location == branch.Location &&
                   Manager_Id == branch.Manager_Id &&
                   Manager_Start_Date == branch.Manager_Start_Date;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Location, Manager_Id, Manager_Start_Date);
        }
    }
}
