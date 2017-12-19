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
    public partial class MainMenu : Form
    {
        //BankUser user = new BankUser("Abcdft78",1234,24680123,13579246,200m,300m,4003); //userID,PIN,savingaccount,checkingaccount,saving balance,checking balance, account num

        private BankUser bankUserM = null;
        Deposit_Withdraw depositForm;
        FormMain logInForm;
        TransferForm transferForm;
        List<BankUser> bankUserDB = BankUserDB.GetProducts();


        public MainMenu()
        {
            InitializeComponent();
        }
        
        public BankUser GetBankUserFromMain()
        {
            return bankUserM;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            logInForm = new FormMain();
            logInForm.Visible = false;
            bankUserM = logInForm.GetBankUser();  //grab data from main form
            bankUserDB.Remove(bankUserM);

        }

        private void EnableControls()
        {
            radioButtonBalance.Enabled = true;
            radioButtonDeposit.Enabled = true;
            radioButtonTransfer.Enabled = true;
            radioButtonWithdrawl.Enabled = true;
            radioButtonExit.Enabled = true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //bankUserDB.Remove(bankUserM); //remove the data from file to rewrite latest changes on file

            if (radioButtonDeposit.Checked) //deposit
            {
                bankUserM.Deposit = true;
                depositForm = new Deposit_Withdraw(bankUserM);
                depositForm.Text = "Deposit";
                this.Visible = false;

                bankUserM = depositForm.getDep_WidthData(); //calls Deposit Form and after is done, it returns Class
                this.Visible = true;

            }
            else if (radioButtonWithdrawl.Checked)  //withdraw
            {
                bankUserM.Deposit = false;
                depositForm = new Deposit_Withdraw(bankUserM);
                depositForm.Text = "Withdraw";
                this.Visible = false;

                bankUserM = depositForm.getDep_WidthData(); //calls Deposit Form and after is done, it returns Class
                this.Visible = true;
            }
            else if (radioButtonBalance.Checked) //balance
            {
                Balance balanceForm = new Balance(bankUserM);
                this.Visible = false;
                balanceForm.ShowDialog();
                this.Visible = true;
            }
            else if (radioButtonTransfer.Checked)  //transfer
            {
                transferForm = new TransferForm(bankUserM);
                this.Visible = false;

                bankUserM = transferForm.getTransferData();  //this calls method in transfer form which calls the showdialog form
                this.Visible = true;
            }
            else
            {
                string message = "Are you sure you want to Logg Off? ";
                DialogResult button =
                    MessageBox.Show(message, "Logg Off!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    for (int x = 0; x < bankUserDB.Count; x++)  //Loop will save changes to list which will update the text file
                    {
                        if (bankUserM.AccountNumber == bankUserDB[x].AccountNumber)
                        {
                            bankUserDB[x].CheckingBalance = bankUserM.CheckingBalance;
                            bankUserDB[x].SavingBalance = bankUserM.SavingBalance;

                            Console.WriteLine("Main loop.. " + bankUserDB[x].UserID + "  " + bankUserDB[x].SavingBalance + " " + bankUserDB[x].CheckingBalance);
                            break;
                        }
                    }

                    BankUserDB.SaveProducts(bankUserDB);

                    this.Visible = false;
                    logInForm.Show();
                }
            }
        }

        
       
    }
}
