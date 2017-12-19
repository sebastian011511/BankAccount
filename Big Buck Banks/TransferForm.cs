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
    public partial class TransferForm : Form
    {
        BankUser bankUserT = null;
        Receipt receiptForm;
        string amount;
        string balance;
        bool checking = false;

        public TransferForm(BankUser t)
        {
            bankUserT = t;
            InitializeComponent();
        }

        

        public BankUser getTransferData()
        {
            this.ShowDialog();

            return bankUserT;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = "";
            textBoxTarget.Text = "";
            textBoxSource.Focus();
            textBoxAmount.Text = "";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                transfer();
                
            }
        }

        public bool IsValidData()
        {
            return Validator.IsPresent(textBoxSource, "Source Account") &&
                Validator.IsPresent(textBoxTarget, "Target Account") &&
                Validator.IsPresent(textBoxAmount, "Amount") &&

                Validator.IsDecimal(textBoxAmount, "Amount") &&
                Validator.IsInt32(textBoxSource, "Source Account") &&
            Validator.IsInt32(textBoxTarget, "Target Account");
        }

        private void transfer()
        {

            if (Convert.ToInt32(textBoxSource.Text) == bankUserT.CheckingAccountNum &&
                Convert.ToDecimal(textBoxAmount.Text) <= bankUserT.CheckingBalance) //If the existing account # matches account entered and source has enough balance
            {
                if (Convert.ToInt32(textBoxTarget.Text) == bankUserT.SavingAccountNum)
                {
                    bankUserT.CheckingBalance -= Convert.ToDecimal(textBoxAmount.Text);
                    bankUserT.SavingBalance += Convert.ToDecimal(textBoxAmount.Text);
                    balance = Convert.ToString(bankUserT.SavingBalance);
                    checking = true;
                    amount = textBoxAmount.Text;
                    callReceipt();
                   // this.Close();
                }
                else
                {
                    MessageBox.Show(textBoxTarget.Text + " is not an existing account number. Please try again.", "Error!");
                    textBoxTarget.Focus();
                }

            }
            else if (Convert.ToInt32(textBoxSource.Text) == bankUserT.SavingAccountNum &&
                Convert.ToDecimal(textBoxAmount.Text) <= bankUserT.SavingBalance) //from savings to checkings
            {
                if (Convert.ToInt32(textBoxTarget.Text) == bankUserT.CheckingAccountNum)
                {
                    bankUserT.SavingBalance -= Convert.ToDecimal(textBoxAmount.Text);
                    bankUserT.CheckingBalance += Convert.ToDecimal(textBoxAmount.Text);
                    balance = Convert.ToString(bankUserT.CheckingBalance);
                    amount = textBoxAmount.Text;
                    callReceipt();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show(textBoxTarget.Text + " is not an existing account number. Please try again.", "Error!");
                    textBoxTarget.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter appropriate account numbers or make sure you have sufficient funds. Please try again.",
                    "Error!");
                textBoxSource.Focus();
            }
            

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void callReceipt()
        {
            //array will hold string info...Account num/Type of transaction/Amount/Total
            string[] receipt = { checking?Convert.ToString(bankUserT.CheckingAccountNum): Convert.ToString(bankUserT.SavingAccountNum),
                    "Transfer", amount, balance};

            receiptForm = new Receipt(receipt); //pass info to next form

            this.Visible = false;
            receiptForm.ShowDialog(); //show form
            this.Close();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {

        }
    }
}
