using System.Globalization;

namespace ClassLibrary.Models.Dashboard
{
    public class SalesChartDTO
    {
        private string date = string.Empty;
        public string Date
        {
            get
            {
                
                return date;
            }
            set
            {
                bool parsed = DateOnly.TryParseExact(value, "MM-dd-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly dateOnly);
                 if(parsed)  
                date = dateOnly.ToString("dd-MMM-yyyy");
                
            }
        }

        public double Revenue { get; set; }
    }
}
