namespace Big_Buck_Banks
{
    partial class Balance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAccntNum = new System.Windows.Forms.Label();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.buttonMainmenu = new System.Windows.Forms.Button();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.textBoxTotalBalance = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelAccntNum
            // 
            this.labelAccntNum.AutoSize = true;
            this.labelAccntNum.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccntNum.Location = new System.Drawing.Point(43, 93);
            this.labelAccntNum.Name = "labelAccntNum";
            this.labelAccntNum.Size = new System.Drawing.Size(143, 21);
            this.labelAccntNum.TabIndex = 1;
            this.labelAccntNum.Text = "Account Number:";
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.ForeColor = System.Drawing.Color.Maroon;
            this.labelMainMenu.Location = new System.Drawing.Point(62, 9);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(255, 52);
            this.labelMainMenu.TabIndex = 3;
            this.labelMainMenu.Text = "Big Bucks Banks";
            // 
            // buttonMainmenu
            // 
            this.buttonMainmenu.Location = new System.Drawing.Point(124, 224);
            this.buttonMainmenu.Name = "buttonMainmenu";
            this.buttonMainmenu.Size = new System.Drawing.Size(161, 38);
            this.buttonMainmenu.TabIndex = 1;
            this.buttonMainmenu.Text = "Main Menu";
            this.buttonMainmenu.UseVisualStyleBackColor = true;
            this.buttonMainmenu.Click += new System.EventHandler(this.buttonMainmenu_Click);
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccount.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(192, 93);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(150, 28);
            this.comboBoxAccount.TabIndex = 0;
            this.comboBoxAccount.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccount_SelectedIndexChanged);
            // 
            // textBoxTotalBalance
            // 
            this.textBoxTotalBalance.Enabled = false;
            this.textBoxTotalBalance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalBalance.Location = new System.Drawing.Point(71, 128);
            this.textBoxTotalBalance.Name = "textBoxTotalBalance";
            this.textBoxTotalBalance.ReadOnly = true;
            this.textBoxTotalBalance.Size = new System.Drawing.Size(271, 79);
            this.textBoxTotalBalance.TabIndex = 6;
            this.textBoxTotalBalance.Text = "";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 274);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxTotalBalance);
            this.Controls.Add(this.comboBoxAccount);
            this.Controls.Add(this.buttonMainmenu);
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.labelAccntNum);
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAccntNum;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Button buttonMainmenu;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.RichTextBox textBoxTotalBalance;
    }
}