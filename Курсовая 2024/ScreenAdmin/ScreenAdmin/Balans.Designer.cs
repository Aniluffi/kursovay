namespace ScreenAdmin
{
    partial class Balans
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
            this.label5 = new System.Windows.Forms.Label();
            this.chet = new System.Windows.Forms.Label();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.textBoxWithdraw = new System.Windows.Forms.TextBox();
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Баланс:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chet
            // 
            this.chet.BackColor = System.Drawing.Color.White;
            this.chet.Location = new System.Drawing.Point(68, 32);
            this.chet.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.chet.Name = "chet";
            this.chet.Size = new System.Drawing.Size(100, 23);
            this.chet.TabIndex = 8;
            this.chet.Text = "0";
            this.chet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(21, 90);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(147, 20);
            this.textBoxDeposit.TabIndex = 10;
            // 
            // textBoxWithdraw
            // 
            this.textBoxWithdraw.Location = new System.Drawing.Point(21, 150);
            this.textBoxWithdraw.Name = "textBoxWithdraw";
            this.textBoxWithdraw.Size = new System.Drawing.Size(147, 20);
            this.textBoxWithdraw.TabIndex = 11;
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(21, 116);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(147, 23);
            this.deposit.TabIndex = 12;
            this.deposit.Text = "Пополнить";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(21, 176);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(147, 23);
            this.withdraw.TabIndex = 13;
            this.withdraw.Text = "Вывести";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // Balans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 450);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.textBoxWithdraw);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chet);
            this.Name = "Balans";
            this.Text = "Balans";
            this.Load += new System.EventHandler(this.Balans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label chet;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.TextBox textBoxWithdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button withdraw;
    }
}