using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Buck_Banks
{
    public partial class Deposit_Withdraw : Form
    {
        private BankUser bankUserD = null;
        Receipt receiptForm;

        //temp values to pass into next form for displaying purposes
        string amount;
        string balance;
        string transaction;
        bool checking = false;

        public Deposit_Withdraw(BankUser user)
        {
            bankUserD = user;
            InitializeComponent();
        }

        public BankUser getDep_WidthData() //get data from deposit/withdraw form
        {
            this.ShowDialog();

            return bankUserD;
        }

        private void Deposit_Withdraw_Load(object sender, EventArgs e)
        {
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (bankUserD.Deposit == true) //if it is a deposit, call deposit method
            {
                if (IsValidData())
                {
                    deposit();   
                }
            }
            else  //if its not deposit, call withdraw method
            {
                if (IsValidData())
                {
                    withdraw();
                }
            }
        }

        private void deposit()
        {
            transaction = "Deposit";

            if (Convert.ToInt32(textBoxAccntNum.Text) == bankUserD.CheckingAccountNum) //If the existing account # matches account entered
            {
                bankUserD.CheckingBalance += Convert.ToDecimal(textBoxAmount.Text); //add entered amount to current balance 
                checking = true;
                balance = Convert.ToString(bankUserD.CheckingBalance);
                amount = textBoxAmount.Text;

                callReceipt();
                //this.Close();
            }
            else if (Convert.ToInt32(textBoxAccntNum.Text) == bankUserD.SavingAccountNum)
            {
                bankUserD.SavingBalance += Convert.ToDecimal(textBoxAmount.Text);
                balance = Convert.ToString(bankUserD.SavingBalance);
                amount = textBoxAmount.Text;

                callReceipt();
                //this.Close();
            }
            else
            {
                MessageBox.Show(textBoxAccntNum.Text + " is not an existing account number. Please try again.", "Error!");
                textBoxAccntNum.Focus();
            }
            
        }

        private void withdraw()
        {
            transaction = "Withdraw";

            if (Convert.ToInt32(textBoxAccntNum.Text) == bankUserD.CheckingAccountNum) //If the existing account # matches account entered
            {
                if (Convert.ToDecimal(textBoxAmount.Text) > bankUserD.CheckingBalance) //Checking to make sure you have funds
                {
                    MessageBox.Show("Insufficient funds. Withdraw another amount.", "Error!");
                    textBoxAmount.Focus();
                }
                else
                {
                    bankUserD.CheckingBalance -= Convert.ToDecimal(textBoxAmount.Text); //suntract entered amount to current balance 
                    balance = Convert.ToString(bankUserD.CheckingBalance);
                    amount = textBoxAmount.Text;
                    checking = true;

                    callReceipt();
                    //this.Close();
                }
            }
            else if (Convert.ToInt32(textBoxAccntNum.Text) == bankUserD.SavingAccountNum) //if accout num matches entered value
            {
                if (Convert.ToDecimal(textBoxAmount.Text) > bankUserD.SavingBalance)  //if entered amount is greater than balance
                {
                    MessageBox.Show("Insufficient funds. Withdraw another amount.", "Error!");
                    textBoxAmount.Focus();
                }
                else
                {
                    bankUserD.SavingBalance -= Convert.ToDecimal(textBoxAmount.Text);
                    balance = Convert.ToString(bankUserD.SavingBalance);
                    amount = textBoxAmount.Text;

                    callReceipt();
                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show(textBoxAccntNum.Text + " is not an existing account number. Please try again.", "Error!");
                textBoxAccntNum.Focus();
            }
            
        }

        public bool IsValidData()
        {
            return Validator.IsPresent(textBoxAmount, "Amount") &&
                Validator.IsPresent(textBoxAccntNum, "Account Number") &&

                Validator.IsDecimal(textBoxAmount, "Amount") &&
                Validator.IsInt32(textBoxAccntNum, "Account Number");
        }

        private void callReceipt() //pass data to receipt
        {
            //array will hold string info...Account num/Type of transaction/Amount/Total
            string[] receipt = { checking?Convert.ToString(bankUserD.CheckingAccountNum): Convert.ToString(bankUserD.SavingAccountNum),
            transaction, amount, balance};

            receiptForm = new Receipt(receipt);

            this.Visible = false;
            receiptForm.ShowDialog();
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAmount.Text = "";
            textBoxAccntNum.Text = "";
            textBoxAccntNum.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 