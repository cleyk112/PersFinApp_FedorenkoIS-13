using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class FormEditProfile : Form
    {
        FormEditProfile instance;
        public FormEditProfile()
        {
            
            InitializeComponent();
            instance = this;
        }
        public FormEditProfile(string Name)
        {
            InitializeComponent();
            instance = this;

            txtProfilename.Text = Name;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            Form1.instance.acc1.Name = txtProfilename.Text;
            Form1.instance.RefreshTransactions(Form1.instance.acc1);
            instance.Close();

        }

        private void FormCreateNewProfile_Load(object sender, EventArgs e)
        {
            
        }
    }
}
