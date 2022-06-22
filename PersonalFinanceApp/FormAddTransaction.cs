namespace PersonalFinanceApp
{
    public partial class FormAddTransaction : Form
    {
        public static FormAddTransaction instance;
        public DateTimePicker datetimepickerinst;
        public ComboBox cmbNameinst;
        public TextBox txtAmountinst;
        public ComboBox txtCategoryinst;
        public TextBox txtDescriptioninst;
        public FormAddTransaction()
        {
            InitializeComponent();
            instance = this;
            cmbNameinst = comboBox2;
            txtAmountinst = textBox2;
            txtCategoryinst = comboBox1;
            txtDescriptioninst = textBox3;
            datetimepickerinst = dateTimePicker1;

            comboBox2.DataSource = Form1.instance.library.companies;
            comboBox1.DataSource = Enum.GetValues(typeof(TCategories));
            btnEdit.Enabled = false;


        }

        public FormAddTransaction(Company cmbComp, DateTime pickerDate, double txtAmount, TCategories cmbCategories,
            string txtDesrciption, int position)
        {
            InitializeComponent();
            instance = this;
            comboBox1.DataSource = Enum.GetValues(typeof(TCategories));
            comboBox2.DataSource = Form1.instance.library.companies;
            button1.Enabled = false;
                  
            comboBox2.Enabled = false;
            comboBox2.SelectedItem = cmbComp;
            textBox2.Text = Convert.ToString(txtAmount);
            textBox3.Text = txtDesrciption;
            label6.Visible = false;
            label6.Text = position.ToString();
            comboBox1.SelectedItem = cmbCategories;
            dateTimePicker1.Value = pickerDate;
           
        }

        private void FormAddTransaction_Load(object sender, EventArgs e)
        {

        }
        public void RefreshComboBox()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = Form1.instance.library.companies;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TCategories categories;
          
            Enum.TryParse<TCategories>(comboBox1.SelectedValue.ToString(), out categories);

            try
            {
                Form1.instance.acc1.AddTransaction((Company)cmbNameinst.SelectedItem, datetimepickerinst.Value, Convert.ToDouble(txtAmountinst.Text),
                categories, txtDescriptioninst.Text);
                Form1.instance.RefreshTransactions(Form1.instance.acc1);
            }
            catch (Exception)
            {
            }     
            FormAddTransaction.instance.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(label6.Text); 
            try
            {
                Form1.instance.acc1.Transactions[pos].TCompany = (Company)comboBox2.SelectedItem;
                Form1.instance.acc1.Transactions[pos].TAmount = Convert.ToDouble(textBox2.Text);
                Form1.instance.acc1.Transactions[pos].TDate = dateTimePicker1.Value;
                Form1.instance.acc1.Transactions[pos].TCategory = (TCategories)comboBox1.SelectedItem;
                Form1.instance.acc1.Transactions[pos].TDescription = textBox3.Text;
            }
            catch (Exception)
            {}

            Account.CalculateNetworth(Form1.instance.acc1);

            Form1.instance.RefreshTransactions(Form1.instance.acc1);

            FormAddTransaction.instance.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddCompany frm  = new FormAddCompany();
            frm.Show();
            RefreshComboBox();
        }
    }

    
}

   