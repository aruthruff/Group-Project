using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week12_Group
{
    public partial class Customer : Form
    {
        private int withdraw;
        private int deposit;
        public decimal balance;
        public string customer;
        public Customer()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            textCustomer.Text = BankApp.AccountName;
            textId.Text =  BankApp.AccountNumber.ToString();
            textBalance.Text = BankApp.balance.ToString();
            balance = BankApp.balance;
        }
            
        
        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDeposit.Text) || !int.TryParse(textDeposit.Text, out deposit))
            {
                MessageBox.Show("Please enter a number");
                textDeposit.Text = " ";
            }
            else
            {
                deposit = Int32.Parse(textDeposit.Text);
                balance = balance + deposit;
                textBalance.Text = balance.ToString();
            }
        }
        
        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textWithdraw.Text) || !int.TryParse(textWithdraw.Text, out withdraw))
            {
                MessageBox.Show("Please enter a number");
                textWithdraw.Text = " ";
            }
           else if (balance >= withdraw)
            {

                balance = Int32.Parse(textBalance.Text);
                withdraw = Int32.Parse(textWithdraw.Text);
                balance = balance - withdraw;
                textBalance.Text = balance.ToString();
            }
           else
            {
                MessageBox.Show("Insufficient Funds");
            }
        }
        
        private void textWithdraw_TextChanged(object sender, EventArgs e)
        {
            textDeposit.Text = "";
        }

        private void textDeposit_TextChanged(object sender, EventArgs e)
        {
            textWithdraw.Text = "";
        }

        private void textDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                depositBtn.PerformClick();
            }
        }

        private void textWithdraw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                withdrawBtn.PerformClick();
            }
        }
    }
}
        
        

            

           
            




            

           
            
           

            
            


        






