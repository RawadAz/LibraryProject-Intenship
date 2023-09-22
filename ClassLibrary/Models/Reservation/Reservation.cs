using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Reservation
{
    public class Reservation
    {
        public int Event_Id { get; set; }
        public int Client_Id { get; set; }
        public int Nb_Of_Tickets { get; set; }
    }
}
