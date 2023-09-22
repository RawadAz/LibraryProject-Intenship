namespace Library.Models.Branch
{
    public class BranchUpdateDTO
    {

        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int? CurrentManagerId { get; set; }
        public int? NewManagerId { get; set; }

        private string managerStartDate = string.Empty;
        public string ManagerStartDate
        {
            get
            {
                bool conversion = DateOnly.TryParseExact(managerStartDate, "MM/dd/yyyy hh:mm:ss", out DateOnly dateOnly);
                if (conversion)
                    managerStartDate = dateOnly.ToString();
                return managerStartDate;
            }
            set { managerStartDate = value; }
        }

    }
}
