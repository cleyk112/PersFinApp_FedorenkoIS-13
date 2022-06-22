namespace PersonalFinanceApp.ClassLibrary
{

    public enum TCategories
    {
        Entertainment,
        Vehicles,
        Clothing,
        Groceries,
        Misc,
        Salary,

    }
    public class Transaction
    {
        public DateTime TDate { get; set; }
        public Company TCompany { get; set; }
        public string TCompName { get; set; }
        public double TAmount { get; set; }
        public string TDescription { get; set; }
        public TCategories TCategory { get; set; }

        public int id = 0;
        private int counter = 0;

        public Transaction()
        {
            TDate = DateTime.Now;
            TCompany = new Company("default");
            TAmount = 0;
            TDescription = "default";
            TCategory = TCategories.Misc;
            id = ++counter;
        }

        public Transaction(Company company, DateTime date, double TAmount, string TDescription, TCategories TCategory)
        {
            TDate = date;
            TCompany = company;
            TCompName = company.Name;
            this.TAmount = TAmount;
            this.TDescription = TDescription;
            this.TCategory = TCategory;
            id = ++counter;
        }
        public Transaction(double TAmount)
        {
            this.TAmount = TAmount;
            id = ++counter;
        }
    }
}
