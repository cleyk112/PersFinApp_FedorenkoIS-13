namespace PersonalFinanceApp.ClassLibrary
{
    public class Company
    {
        public string Name { get; set; }
        public double alltimeSum { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Company(string Name)
        {
            this.Name = Name;

            Transactions = new List<Transaction>();

        }

        public void AddTransaction(Company _company, DateTime _date, double _TAmount, TCategories _TCategory, string _TDescription)
        {
            Transactions?.Add(new Transaction(_company, _date, _TAmount, _TDescription, _TCategory));

            alltimeSum += _TAmount;
        }

        public void AddTransaction(Transaction tr)
        {
            Transactions?.Add(tr);

            alltimeSum += tr.TAmount;
        }
        public void RemoveTransaction(Transaction transaction)
        {
            Transactions?.Remove(transaction);
            alltimeSum -= transaction.TAmount;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
