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
    public partial class FormAddCompany : Form
    {
        FormAddCompany instance;
        public FormAddCompany()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    Form1.instance.library.AddAccountToRepository(textBox1.Text);
                }
                catch (Exception)
                { }
            } 
            FormAddTransaction.instance.RefreshComboBox();
            instance.Close();
        }
    }

    public partial class CopyOfFormAddCompany : Form
    {
        CopyOfFormAddCompany instance;
        public CopyOfFormAddCompany()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    Form1.instance.library.AddAccountToRepository(textBox1.Text);
                }
                catch (Exception)
                { }
            }
            FormAddTransaction.instance.RefreshComboBox();
            instance.Close();
        }
    }

    public partial class CopyOfCopyOfFormAddCompany : Form
    {
        CopyOfCopyOfFormAddCompany instance;
        public CopyOfCopyOfFormAddCompany()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    Form1.instance.library.AddAccountToRepository(textBox1.Text);
                }
                catch (Exception)
                { }
            }
            FormAddTransaction.instance.RefreshComboBox();
            instance.Close();
        }
    }
}
