using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Buck_Banks
{
    public static class BankUserDB
    {
        private const string dir = @"C:\Users\My Documents\OOPL\Big Buck Banks\";
        private const string path = dir + "BankUser.txt";

        public static List<BankUser> GetProducts()
        {
            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the list
            List<BankUser> bankUser = new List<BankUser>();

            // read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                BankUser user = new BankUser();
                user.UserID = columns[0];
                user.Password = Convert.ToInt32(columns[1]);
                user.SavingAccountNum = Convert.ToInt32(columns[2]);
                user.CheckingAccountNum = Convert.ToInt32(columns[3]);
                user.CheckingBalance = Convert.ToDecimal(columns[4]);
                user.SavingBalance = Convert.ToDecimal(columns[5]);
                user.AccountNumber = Convert.ToInt32(columns[6]);
                bankUser.Add(user);
            }

            // close the input stream for the text file
            textIn.Close();

            return bankUser;
        }

        public static void SaveProducts(List<BankUser> bankUser)
        {
            // create the output stream for a text file that exists
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each product
            foreach (BankUser user in bankUser)
            {
                textOut.Write(user.UserID + "|");
                textOut.Write(user.Password + "|");
                textOut.Write(user.SavingAccountNum + "|");
                textOut.Write(user.CheckingAccountNum + "|");
                textOut.Write(user.CheckingBalance + "|");
                textOut.Write(user.SavingBalance + "|");
                textOut.WriteLine(user.AccountNumber);
            }

            // close the output stream for the text file
            textOut.Close();
        }

    }
}
