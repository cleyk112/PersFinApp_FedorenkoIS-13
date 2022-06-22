namespace PersonalFinanceApp
{
    public partial class Form1 : Form
    {

        public static Form1 instance;

        public Account acc1 = new Account("Yaroslav");

        public CompanyLibrary library = new CompanyLibrary();






        public Form1()
        {
            InitializeComponent();
            instance = this;


            library.companies.Add(new Company("Steam"));
            library.companies.Add(new Company("Opel"));
            library.companies.Add(new Company("Silpo"));
            library.companies.Add(new Company("Siemens"));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            acc1.AddTransaction(library.companies[0], new DateTime(2022, 2, 2), -500, TCategories.Entertainment, "In-game transaction");
            acc1.AddTransaction(library.companies[1], new DateTime(2022, 6, 2), -10000, TCategories.Vehicles, "Car parts purchase");
            acc1.AddTransaction(library.companies[2], new DateTime(2022, 6, 8), -2000, TCategories.Groceries, "Grocery shopping");
            acc1.AddTransaction(library.companies[3], new DateTime(2022, 5, 2), 15000, TCategories.Misc, "Salary");




            cmbboxSrtCategory.DataSource = Enum.GetValues(typeof(TCategories));

            RefreshNetPeriodDisplay();
            RefreshTransactions(acc1);



        }
        public void RefreshTransactions(Account acc)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = acc.Transactions;
            lblName.Text = acc.Name;

            if (acc.networth > 0)
            {
                lblNetworth.ForeColor = Color.DarkGreen;
                lblNetworth.Text = "+" + Convert.ToString(acc1.networth) + " 📈";
            }
            else if (acc.networth < 0)
            {
                lblNetworth.ForeColor = Color.DarkRed;
                lblNetworth.Text = Convert.ToString(acc1.networth) + " 📉";
            }
            else
            {
                lblNetworth.Text = Convert.ToString(acc1.networth);
            }
        }

        public void RefreshTransactions(Account acc, List<Transaction> transactions)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transactions;
            lblName.Text = acc.Name;

            double periodnetchange = 0;

            foreach (var item in transactions)
            {
                periodnetchange += item.TAmount;
            }

            lblNetPeriod.Text = Convert.ToString(periodnetchange);

        }
        public void RefreshNetPeriodDisplay()
        {
            double netPeriod = 0;
            foreach (var item in acc1.Transactions)
            {
                if (dateTimePickerFrom.Value >= item.TDate && dateTimePickerTo.Value <= item.TDate)
                {
                    netPeriod += item.TAmount;
                }
            }
            lblNetPeriod.Text = Convert.ToString(netPeriod);
        }
        private void btnAddT_Click(object sender, EventArgs e)
        {
            FormAddTransaction frm = new FormAddTransaction();
            frm.ShowDialog();
            frm.Close();
        }
        private void txtCreateProfile_Click(object sender, EventArgs e)
        {
            FormEditProfile frm = new FormEditProfile(acc1.Name);
            frm.Show();

        }
        private void btnRemoveTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                int position = dataGridView1.CurrentRow.Index;

                for (int i = 0; i < acc1.Transactions.Count; i++)
                {
                    if (i == position)
                    {
                        acc1.RemoveTransaction(acc1.Transactions[i]);
                        
                    }
                }
            }
            catch (Exception)
            { }
            RefreshTransactions(acc1);
        }
        private void btnResetPeriod_Click(object sender, EventArgs e)
        {
            RefreshTransactions(acc1);
            lblNetPeriod.Text = "0";
        }
        private void btnSortPeriod_Click(object sender, EventArgs e)
        {
            List<Transaction> DateSortedList = new List<Transaction>();

            foreach (var item in acc1.Transactions)
            {
                if (dateTimePickerFrom.Value <= item.TDate && dateTimePickerTo.Value >= item.TDate)
                {
                    DateSortedList.Add(item);
                }
            }
            RefreshTransactions(acc1, DateSortedList);
        }
        private void btnSortCategory_Click(object sender, EventArgs e)
        {
            try
            {
                List<Transaction> CategorySortedList = new List<Transaction>();
                TCategories category;

                if (Enum.TryParse<TCategories>(cmbboxSrtCategory.SelectedValue.ToString(), out category))
                {
                    foreach (var item in acc1.Transactions)
                    {
                        if (item.TCategory == category)
                        {
                            CategorySortedList.Add(item);
                        }
                    }
                }
                RefreshTransactions(acc1, CategorySortedList);
            }
            catch (Exception)
            {


            }




        }
        private void btnEditT_Click(object sender, EventArgs e)
        {
            try
            {
                int position = dataGridView1.CurrentRow.Index;

                FormAddTransaction frmedit = new FormAddTransaction(acc1.Transactions[position].TCompany, acc1.Transactions[position].TDate,
                    acc1.Transactions[position].TAmount, acc1.Transactions[position].TCategory, acc1.Transactions[position].TDescription, position);
                frmedit.Show();
                RefreshTransactions(acc1);
            }
            catch (Exception)
            {    }
            
        }
        private void btnShowCompDetails_Click(object sender, EventArgs e)
        {
            try
            {
                int position = dataGridView1.CurrentRow.Index;
                for (int i = 0; i < acc1.Transactions.Count; i++)
                {
                    if (i == position)
                    {
                        FormShowCompanyDetails frm = new FormShowCompanyDetails(acc1.Transactions[i].TCompany);
                        frm.Show();
                    }
                }
            }
            catch (Exception)
            {      }
        }
    }

   
}