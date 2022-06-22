namespace PersonalFinanceApp
{

    public class Account
    {
        public List<Transaction> Transactions { get; set; } //Unic list for each new account wich contains it's transactions

        public string Name { get; set; }
        public double networth { get; set; }

        public int id = 0;
        private int counter = 0;

        public Account(string Name)
        {
            this.Name = Name;

            Transactions = new List<Transaction>();
            id = ++counter;
        }
        public void AddTransaction(Company _company, DateTime _date, double _TAmount, TCategories _TCategory, string _TDescription)
        {
            Transactions?.Add(new Transaction(_company, _date, _TAmount, _TDescription, _TCategory));
            _company.AddTransaction(Transactions.Last());
            networth += _TAmount;
        }

        public void AddTransaction(Transaction tr)
        {
            Transactions?.Add(tr);

            networth += tr.TAmount;
        }
        public void RemoveTransaction(Transaction transaction)
        {

            Transactions?.Remove(transaction);
            transaction.TCompany.RemoveTransaction(transaction);
            networth -= transaction.TAmount;
        }

        public static double CalculateNetworth(Account acc)
        {
            acc.networth = 0;
            foreach (var item in acc.Transactions)
            {
                acc.networth += item.TAmount;
            }
            return acc.networth;
        }

    }
}
