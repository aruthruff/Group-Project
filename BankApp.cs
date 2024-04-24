using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12_Group
{
    public partial class BankApp : Form
    {
        public static string AccountName = "";
        public static int AccountNumber;
        public static decimal balance;

        public BankApp()
        {
            InitializeComponent();
            Customer f2 = new Customer();
        }
        
        private void textAccountNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            AccountName = textAccountName.Text;
            AccountNumber = int.Parse(textAccountNum.Text);
            balance = decimal.Parse(textBalance.Text);

            Customer f2 = new Customer();
            f2.Show();
        }
        
        private void textBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createAccountBtn.PerformClick();
            }
        }
    }
}
            
        
        

            

           


            
            


            

            
            
            

            


