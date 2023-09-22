namespace ClassLibrary.Models.Dashboard
{
    public class TopBookChartInfo
    {
        private string name = string.Empty;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToUpper();
            }
        }
        public int Sold_Books { get; set; }
    }
}
