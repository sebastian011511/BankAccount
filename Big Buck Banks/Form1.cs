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
    public partial class FormMain : Form
    {
        MainMenu mainMenu = new MainMenu();
        private string[] admin = { "admin123", "1010" }; //userID and pass
        private string[] closeWindow ={ "close123","1010"}; //close window
        private List<BankUser> bankUsers = null;

        public FormMain()
        {
            InitializeComponent();
            textBoxUD.Focus();
        }

        private static BankUser bankUser = new BankUser(); //("asdfghj1", 1234, 10000010, 20000020, 200m, 200m, 4003); //userID,PIN,savingaccount,checkingaccount,saving balance,checking balance, account num
        static int currentIndex;
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            bankUsers = BankUserDB.GetProducts();
            textBoxMessage.Cursor = Cursors.No; //blocks message block
        }

        public bool userExist() //check if user info entered exist
        {
            int pass;
            bool verified = false;
            int index = 0;

            Int32.TryParse(textBoxPassw.Text, out pass);
            string userID = textBoxUD.Text;

            //Loop checks record for user ID entered
            for (int value = 0; value < bankUsers.Count; value++)
            {
                if (bankUsers[value].UserID == userID)
                {
                    currentIndex = value;

                    if (bankUsers[value].Password == pass)
                    {
                        verified = true;
                        index = value;
                        break;
                    }
                }
            }

            if (!verified)
            {
                textBoxMessage.Text = "The user ID entered does not match the password we have on record.\nPlease try again.";
                textBoxUD.Focus();
                bankUsers[index].NumOfAttempts++;

                if (bankUsers[index].NumOfAttempts >= 3)  //if 3 attemps failed, lock the account.
                    bankUsers[index].Locked = true;

                return false;
            }
            else
                return true;

            /**if (userID == bankUser.UserID)  //if user ID/password match with actual ID and password, return true
            {
                if (pass == bankUser.Password)
                    return true;
                else
                {
                    textBoxMessage.Text = "The user ID entered does not match the password we have on record.\nPlease try again.";
                    textBoxUD.Focus();
                    bankUser.NumOfAttempts++; //increment num of attempts
                    if (bankUser.NumOfAttempts >= 3)  //if 3 attemps failed, lock the account.
                        bankUser.Locked = true;
                    return false;
                }
            }
            else
                return false;*/
        }

        public BankUser GetBankUser() //method to get data from main form
        {
            return bankUser;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData()) //Input validation
                {
                    if (userExist() && !bankUsers[currentIndex].Locked) //Makes sure the user exist.  Meaning if the login info match record
                    {
                        //mainMenu.Focus();
                        //this.Close();

                        bankUser = bankUsers[currentIndex];
                        Console.WriteLine(bankUser.AccountNumber + "  " + bankUser.CheckingBalance);
                        Console.WriteLine(bankUsers[currentIndex].AccountNumber + "  " + bankUsers[currentIndex].CheckingBalance);
                        mainMenu.Show();
                        this.Visible = false;
                        //BankUser customer=mainMenu.Get
                    }
                    else if (bankUsers[currentIndex].Locked) //if account locked, wait for admin to unlock
                    {
                        textBoxUD.Text = "";
                        textBoxPassw.Text = "";
                        buttonClear.Visible = false;
                        buttonLogIn.Visible = false;
                        textBoxMessage.Text = "PLEASE SEE BANK OFFICER - NO FURTHER LOGIN ATTEMPTS ALLOWED." +
                            "\nAny further questions, call the bank. Bank number: 1-800-Big-Bucks";

                        buttonAdmin.Visible = true;
                        
                       //adminUnlock();
                    }
                    else if (textBoxUD.Text == closeWindow[0] && textBoxPassw.Text == closeWindow[1]) //admin closing atm
                    {
                        string message = "Are you sure you want to shut down ATM? ";
                        DialogResult button =
                            MessageBox.Show(message, "ATM Shut Down!",
                            MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                        if (button == DialogResult.Yes)
                            System.Environment.Exit(1); //Close whole application
                    }
                    else
                    {
                        textBoxUD.Focus();
                        textBoxMessage.Text = "The user ID entered does not match the password we have on record.\nPlease try again.";
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }


        }



        public bool IsValidData()
        {
            return Validator.IsPresent(textBoxUD, "User ID") &&
                Validator.IsPresent(textBoxPassw, "Password") &&

                Validator.IsFieldComplete(textBoxUD,"User ID",8)&&
                Validator.UserIDComplete(textBoxUD)&&

                Validator.IsInt32(textBoxPassw, "Password") &&
                Validator.IsFieldComplete(textBoxPassw,"Password", 4);
        }
        
        private void adminUnlock()
        {
            //if (textBoxUD.Text == admin[0] && textBoxPassw.Text == admin[1])
            //{
            textBoxUD.Focus();
           
            string test = "Test"+ textBoxUD.Text;
            Console.WriteLine(test);
            textBoxUD.TabStopChanged += new EventHandler(buttonClear_Click);
            bankUsers[currentIndex].Locked = false;
            //}

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUD.Text = "";
            textBoxPassw.Text = "";
            textBoxUD.Focus();
            textBoxMessage.Text = "";
            buttonLogIn.Enabled = true;
            buttonClear.Enabled = true;
        }

        private void textBoxUD_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    if (admin[0] == textBoxUD.Text && admin[1] == textBoxPassw.Text)
                    {
                        buttonClear.Visible = true;
                        buttonLogIn.Visible = true;
                        buttonAdmin.Visible = false;
                        textBoxPassw.Text = "";
                        textBoxUD.Text = "";
                        textBoxUD.Focus();
                        textBoxMessage.Text = "ATM is now UNLOCK!";
                        bankUsers[currentIndex].Locked = false;
                    }else
                    {
                        textBoxUD.Focus();
                        textBoxMessage.Text = "The Admin ID entered does not match the password we have on record.\nPlease try again.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }
    }
}
