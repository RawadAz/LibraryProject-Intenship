using Microsoft.CodeAnalysis.CSharp;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Asn1.Cms;

namespace Library.Models.Branch
{
    public class Branch
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int? Manager_Id { get; set; }

        private string? manager_Start_Date;

        public string? Manager_Start_Date
        {
            get
            {
                bool dateParsed = DateOnly.TryParseExact(manager_Start_Date, "MM/dd/yyyy hh:mm:ss", out DateOnly date);
                if(dateParsed)
                    manager_Start_Date = date.ToString();

                return manager_Start_Date;
            }
            set
            {
                manager_Start_Date= value;
            }
        }

        
    }
}
