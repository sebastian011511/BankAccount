using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Buck_Banks
{
    public class BankUser
    {
        private string userID;
        private int password;
        private int savingAccntNum;
        private int checkingAccntNum;
        private decimal balanceChecking;
        private decimal balanceSaving;
        private int accountNum;
        private int numOfAttempts = 0;  //keep track to attempts b4 locking account
        private bool locked = false;  //is account locked
        //This will help reuse a form 
        private bool deposit;    //bool will allow me to re-use one form for deposit or withdraws.  This bool will help rename some variables
        private bool checking;

        public BankUser() { }

        public BankUser(string userID, int password, int savingAccntNum, int checkingAccntNum, decimal balanceChecking, 
            decimal balanceSaving, int accountNum)
        {
            this.userID = userID;
            this.password = password;
            this.savingAccntNum = savingAccntNum;
            this.checkingAccntNum = checkingAccntNum;
            this.balanceChecking = balanceChecking;
            this.balanceSaving = balanceSaving;
            this.accountNum = accountNum;
        }

        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        public int Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }

        }

        public int SavingAccountNum
        {
            get
            {
                return savingAccntNum;
            }
            set
            {
                savingAccntNum = value;
            }
        }  

        public int CheckingAccountNum
        {
            get
            {
                return checkingAccntNum;
            }
            set
            {
                checkingAccntNum = value;
            }
        }

        public decimal CheckingBalance
        {
            get
            {
                return balanceChecking;
            }
            set
            {
                balanceChecking = value;
            }
        }

        public decimal SavingBalance
        {
            get
            {
                return balanceSaving;
            }
          set
            {
                balanceSaving = value;
            }
        }

        public int AccountNumber
        {
            get
            {
                return accountNum;
            }
            set
            {
                accountNum = value;
            }
        }

        public int NumOfAttempts
        {
            get
            {
                return numOfAttempts;
            }

            set
            {
                numOfAttempts = value;
            }
        }

        public bool Locked
        {
            get
            {
                return locked;
            }

            set
            {
                locked = value;
            }
        }

        public bool Deposit
        {
            get
            {
                return deposit;
            }

            set
            {
                deposit = value;
            }
        }
    }
}
