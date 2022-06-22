namespace PersonalFinanceApp
{
    public partial class FormShowCompanyDetails : Form
    {
        FormShowCompanyDetails instance;
        public FormShowCompanyDetails()
        {
            InitializeComponent();
            instance = this;
        }
        public FormShowCompanyDetails(Company company)
        {
            InitializeComponent();
            instance = this;

            lblName.Text = company.Name;
            lblCount.Text = Convert.ToString(company.Transactions.Count);
            dataGridView1.DataSource = company.Transactions;

        }
    }

}
