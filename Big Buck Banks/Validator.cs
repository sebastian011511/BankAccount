using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 *This class just validates user input.
 * */

namespace Big_Buck_Banks
{
    public static class Validator
    {
        private static string error = "Entry Error!";

        public static string Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }

        public static bool IsPresent(TextBox textBox, string message)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(message + " is a required field.", error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
                return true;
            else
            {
                MessageBox.Show(name + " must be a decimal value.", error);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox, string message)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
                return true;
            else
            {
                MessageBox.Show(message + " must be in digits.", error);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsFieldComplete(TextBox textbox,string message, int value)
        {
            var pin = textbox.Text.ToCharArray();

            if (pin.Length != value)
            {
                MessageBox.Show("Please enter a complete " + message, error);
                textbox.Focus();
                return false;
            }
            else
                return true;
        }

        public static bool UserIDComplete(TextBox textbox)
        {
            string ID = textbox.Text;
            var id = textbox.Text.ToCharArray();
            ID = ID.Trim(); //Any empty spaces deleted @ begining of string of after
            bool digitCheck=false;

            for (int value = 0; value < id.Length; value++)
            {
                if (char.IsDigit(ID, value)){
                    digitCheck = true;
                    break;
                }
            }

            if (char.IsDigit(ID, 0) | digitCheck==false) //First index of string is digit(which it shouldnt) && string contains not digits
            { 
                MessageBox.Show("User ID does not contain: \n1.\tAlphanumeric characters\n\tor\n2.\tDoes not begin with a letter. ", error);
                textbox.Focus();
                return false;
            }
            else
                return true;
        }
    }
}
