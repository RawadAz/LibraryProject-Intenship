namespace Library.Models.DashBoard
{
    public class SalesChartInfo
    {
        private string? date;
        public string? Date
        {
            get
            {
                bool dateTimeParsed = DateTime.TryParseExact(date, "MM/dd/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime dateTime);
                if (dateTimeParsed)
                    date = dateTime.ToString("MM/dd/yyyy hh:mm:ss tt");
                return date;
            }
            set
            {
                date = value;
            }
        }
        public double Revenue { get; set; }
    }
}
