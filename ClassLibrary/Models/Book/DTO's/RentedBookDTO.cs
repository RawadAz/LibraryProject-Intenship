﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Book.DTO_s
{
    public class RentedBookDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Purchase_Price { get; set; }
        public double Rent_Price { get; set; }
        public int In_Stock { get; set; }
        public string Branch_Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Transaction_Id { get; set; }
    }
}