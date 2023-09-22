using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Event.DTO
{
    public class EventDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Date { get; set; } = string.Empty;

        public int? Branch_id { get; set; }

        public string Branch_Name { get; set; } = string.Empty;

        public int Available_seats { get; set; }
        public double Fee { get; set; }
        public string Recurrence { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

    }
}
