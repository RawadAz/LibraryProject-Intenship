using System.Globalization;

namespace ClassLibrary.Models.Dashboard
{
    public class SalesChartDailyDTO
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
                bool parsed = DateTime.TryParseExact(value, "MM-dd-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime);
                if (parsed)
                    date = dateTime.ToString("hh:MM tt");

            }
        }

        public double Revenue { get; set; }
    }
}
