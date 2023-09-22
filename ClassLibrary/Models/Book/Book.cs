using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Book
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Purchase_Price { get; set; }
        public double Rent_Price { get; set; }
        public int Branch_Id { get; set; }
        public int In_Stock { get; set; }
        public string Description { get; set; } = string.Empty;

        public override bool Equals(object? obj)
        {
            return obj is Book book &&
                   Id == book.Id &&
                   Name == book.Name &&
                   Author == book.Author &&
                   Category == book.Category &&
                   Purchase_Price == book.Purchase_Price &&
                   Rent_Price == book.Rent_Price &&
                   Branch_Id == book.Branch_Id &&
                   In_Stock == book.In_Stock &&
                   Description == book.Description;
        }

        public override int GetHashCode()
        {
            HashCode hash = new();
            hash.Add(Id);
            hash.Add(Name);
            hash.Add(Author);
            hash.Add(Category);
            hash.Add(Purchase_Price);
            hash.Add(Rent_Price);
            hash.Add(Branch_Id);
            hash.Add(In_Stock);
            hash.Add(Description);
            return hash.ToHashCode();
        }
    }
}
