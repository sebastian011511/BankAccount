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
    public partial class Balance : Form
    {
        BankUser bankUserB;

        public Balance(BankUser user)
        {
            bankUserB = user;
            InitializeComponent();

            var accntNum = bankUserB.CheckingAccountNum.ToString();
            var accnt = "Ending in " + accntNum.Substring(accntNum.Length - 4, 4);

            comboBoxAccount.Items.Add(accnt);

            accntNum= bankUserB.SavingAccountNum.ToString();
            accnt= "Ending in " + accntNum.Substring(accntNum.Length - 4, 4);

            comboBoxAccount.Items.Add(accnt);
            comboBoxAccount.SelectedIndex = 0;

        }

        private void Balance_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTotalBalance.SelectionAlignment = HorizontalAlignment.Center;

            if (comboBoxAccount.SelectedIndex == 0)
                textBoxTotalBalance.Text = "Slected Account Balance:\n" + bankUserB.CheckingBalance.ToString("c");
            else if (comboBoxAccount.SelectedIndex == 1)
                textBoxTotalBalance.Text = "Selected Account Balance:\n" + bankUserB.SavingBalance.ToString("c");
        }

        private void buttonMainmenu_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
