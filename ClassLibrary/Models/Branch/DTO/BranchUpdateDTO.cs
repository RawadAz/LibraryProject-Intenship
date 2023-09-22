using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Branch.DTO
{
    public class BranchUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int? CurrentManagerId { get; set; }
        public int? NewManagerId { get; set; }
        public string? ManagerStartDate { get; set; } = string.Empty;
    }
}
