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
    public partial class Receipt : Form
    {
        string [] receipt=new string[4];  //String will hold Account num/Type of transaction/Amount/Total

        public Receipt(string [] r)
        {
            InitializeComponent();
            for(int x = 0; x < r.Length; x++) //copy passed array 
            {
                receipt[x] = r[x];
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            decimal tempHold = Convert.ToDecimal(receipt[2]);

            string accntMod = "-"+receipt[0].Substring(receipt[0].Length - 4, 4);


            textBoxAccountNum.Text = accntMod;    //Account number
            textBoxTypeTransaction.Text = receipt[1];   //Transfer, Withdraw, Deposit
            textBoxAmount.Text = tempHold.ToString("c");    //Amount

            tempHold = Convert.ToDecimal(receipt[3]);
            textBoxBalance.Text = tempHold.ToString("c");   //Balance

            buttonDone.Focus();
        }
    }
}
