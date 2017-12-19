namespace Big_Buck_Banks
{
    partial class Receipt
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
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.textBoxAccountNum = new System.Windows.Forms.RichTextBox();
            this.textBoxAmount = new System.Windows.Forms.RichTextBox();
            this.textBoxTypeTransaction = new System.Windows.Forms.RichTextBox();
            this.textBoxBalance = new System.Windows.Forms.RichTextBox();
            this.labelAccntNum = new System.Windows.Forms.Label();
            this.labelTypeTrans = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(90, 67);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(267, 17);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "For Customer Service Call 800.BIG.BUCK";
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(90, 95);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(257, 17);
            this.labelWebsite.TabIndex = 2;
            this.labelWebsite.Text = "Visit Our Website at BigBucksBank.com";
            // 
            // textBoxAccountNum
            // 
            this.textBoxAccountNum.Location = new System.Drawing.Point(26, 167);
            this.textBoxAccountNum.Name = "textBoxAccountNum";
            this.textBoxAccountNum.ReadOnly = true;
            this.textBoxAccountNum.Size = new System.Drawing.Size(157, 38);
            this.textBoxAccountNum.TabIndex = 1;
            this.textBoxAccountNum.Text = "";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(333, 167);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(157, 38);
            this.textBoxAmount.TabIndex = 3;
            this.textBoxAmount.Text = "";
            // 
            // textBoxTypeTransaction
            // 
            this.textBoxTypeTransaction.Location = new System.Drawing.Point(177, 167);
            this.textBoxTypeTransaction.Name = "textBoxTypeTransaction";
            this.textBoxTypeTransaction.ReadOnly = true;
            this.textBoxTypeTransaction.Size = new System.Drawing.Size(157, 38);
            this.textBoxTypeTransaction.TabIndex = 2;
            this.textBoxTypeTransaction.Text = "";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(332, 208);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(157, 38);
            this.textBoxBalance.TabIndex = 4;
            this.textBoxBalance.Text = "";
            // 
            // labelAccntNum
            // 
            this.labelAccntNum.AutoSize = true;
            this.labelAccntNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccntNum.Location = new System.Drawing.Point(47, 147);
            this.labelAccntNum.Name = "labelAccntNum";
            this.labelAccntNum.Size = new System.Drawing.Size(113, 17);
            this.labelAccntNum.TabIndex = 7;
            this.labelAccntNum.Text = "Account Number";
            // 
            // labelTypeTrans
            // 
            this.labelTypeTrans.AutoSize = true;
            this.labelTypeTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeTrans.Location = new System.Drawing.Point(187, 147);
            this.labelTypeTrans.Name = "labelTypeTrans";
            this.labelTypeTrans.Size = new System.Drawing.Size(135, 17);
            this.labelTypeTrans.TabIndex = 8;
            this.labelTypeTrans.Text = "Type of Transaction";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(371, 147);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(56, 17);
            this.labelAmount.TabIndex = 9;
            this.labelAmount.Text = "Amount";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(202, 220);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(120, 17);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "Available Balance";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(50, 212);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(123, 34);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.ForeColor = System.Drawing.Color.Maroon;
            this.labelMainMenu.Location = new System.Drawing.Point(102, 15);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(255, 52);
            this.labelMainMenu.TabIndex = 11;
            this.labelMainMenu.Text = "Big Bucks Banks";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 284);
            this.ControlBox = false;
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelTypeTrans);
            this.Controls.Add(this.labelAccntNum);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxTypeTransaction);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxAccountNum);
            this.Controls.Add(this.labelWebsite);
            this.Controls.Add(this.labelPhone);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.RichTextBox textBoxAccountNum;
        private System.Windows.Forms.RichTextBox textBoxAmount;
        private System.Windows.Forms.RichTextBox textBoxTypeTransaction;
        private System.Windows.Forms.RichTextBox textBoxBalance;
        private System.Windows.Forms.Label labelAccntNum;
        private System.Windows.Forms.Label labelTypeTrans;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label labelMainMenu;
    }
}