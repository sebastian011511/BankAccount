namespace Big_Buck_Banks
{
    partial class MainMenu
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
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.radioButtonBalance = new System.Windows.Forms.RadioButton();
            this.radioButtonExit = new System.Windows.Forms.RadioButton();
            this.radioButtonTransfer = new System.Windows.Forms.RadioButton();
            this.radioButtonWithdrawl = new System.Windows.Forms.RadioButton();
            this.radioButtonDeposit = new System.Windows.Forms.RadioButton();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxMenu.Controls.Add(this.radioButtonBalance);
            this.groupBoxMenu.Controls.Add(this.radioButtonExit);
            this.groupBoxMenu.Controls.Add(this.radioButtonTransfer);
            this.groupBoxMenu.Controls.Add(this.radioButtonWithdrawl);
            this.groupBoxMenu.Controls.Add(this.radioButtonDeposit);
            this.groupBoxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenu.Location = new System.Drawing.Point(127, 75);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMenu.Size = new System.Drawing.Size(284, 190);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            // 
            // radioButtonBalance
            // 
            this.radioButtonBalance.AutoSize = true;
            this.radioButtonBalance.Location = new System.Drawing.Point(32, 22);
            this.radioButtonBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBalance.Name = "radioButtonBalance";
            this.radioButtonBalance.Size = new System.Drawing.Size(131, 23);
            this.radioButtonBalance.TabIndex = 0;
            this.radioButtonBalance.TabStop = true;
            this.radioButtonBalance.Text = "Check Balance";
            this.radioButtonBalance.UseVisualStyleBackColor = true;
            // 
            // radioButtonExit
            // 
            this.radioButtonExit.AutoSize = true;
            this.radioButtonExit.Location = new System.Drawing.Point(32, 130);
            this.radioButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonExit.Name = "radioButtonExit";
            this.radioButtonExit.Size = new System.Drawing.Size(58, 23);
            this.radioButtonExit.TabIndex = 4;
            this.radioButtonExit.TabStop = true;
            this.radioButtonExit.Text = "Exit";
            this.radioButtonExit.UseVisualStyleBackColor = true;
            // 
            // radioButtonTransfer
            // 
            this.radioButtonTransfer.AutoSize = true;
            this.radioButtonTransfer.Location = new System.Drawing.Point(32, 76);
            this.radioButtonTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTransfer.Name = "radioButtonTransfer";
            this.radioButtonTransfer.Size = new System.Drawing.Size(130, 23);
            this.radioButtonTransfer.TabIndex = 2;
            this.radioButtonTransfer.TabStop = true;
            this.radioButtonTransfer.Text = "Transfer Funds";
            this.radioButtonTransfer.UseVisualStyleBackColor = true;
            // 
            // radioButtonWithdrawl
            // 
            this.radioButtonWithdrawl.AutoSize = true;
            this.radioButtonWithdrawl.Location = new System.Drawing.Point(32, 49);
            this.radioButtonWithdrawl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonWithdrawl.Name = "radioButtonWithdrawl";
            this.radioButtonWithdrawl.Size = new System.Drawing.Size(153, 23);
            this.radioButtonWithdrawl.TabIndex = 1;
            this.radioButtonWithdrawl.TabStop = true;
            this.radioButtonWithdrawl.Text = "Make a Withdrawl";
            this.radioButtonWithdrawl.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeposit
            // 
            this.radioButtonDeposit.AutoSize = true;
            this.radioButtonDeposit.Location = new System.Drawing.Point(32, 103);
            this.radioButtonDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDeposit.Name = "radioButtonDeposit";
            this.radioButtonDeposit.Size = new System.Drawing.Size(137, 23);
            this.radioButtonDeposit.TabIndex = 3;
            this.radioButtonDeposit.TabStop = true;
            this.radioButtonDeposit.Text = "Make a Deposit";
            this.radioButtonDeposit.UseVisualStyleBackColor = true;
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.ForeColor = System.Drawing.Color.Maroon;
            this.labelMainMenu.Location = new System.Drawing.Point(55, 10);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(425, 52);
            this.labelMainMenu.TabIndex = 2;
            this.labelMainMenu.Text = "Big Bucks Banks Main Menu";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(205, 306);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(124, 33);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 354);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.groupBoxMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.RadioButton radioButtonExit;
        private System.Windows.Forms.RadioButton radioButtonTransfer;
        private System.Windows.Forms.RadioButton radioButtonWithdrawl;
        private System.Windows.Forms.RadioButton radioButtonDeposit;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.RadioButton radioButtonBalance;
    }
}