
namespace WinFormsUI
{
    partial class Transactions
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CashWithdrawalAmount = new System.Windows.Forms.NumericUpDown();
            this.customerText = new System.Windows.Forms.Label();
            this.ProcessTransactionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CashWithdrawalAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cash Withdrawal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // CashWithdrawalAmount
            // 
            this.CashWithdrawalAmount.Location = new System.Drawing.Point(84, 133);
            this.CashWithdrawalAmount.Maximum = new decimal(new int[] {
            -402653184,
            -1613725636,
            54210108,
            0});
            this.CashWithdrawalAmount.Name = "CashWithdrawalAmount";
            this.CashWithdrawalAmount.Size = new System.Drawing.Size(120, 23);
            this.CashWithdrawalAmount.TabIndex = 3;
            // 
            // customerText
            // 
            this.customerText.AutoSize = true;
            this.customerText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerText.Location = new System.Drawing.Point(126, 78);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(67, 21);
            this.customerText.TabIndex = 4;
            this.customerText.Text = "<none>";
            // 
            // ProcessTransactionButton
            // 
            this.ProcessTransactionButton.Location = new System.Drawing.Point(7, 186);
            this.ProcessTransactionButton.Name = "ProcessTransactionButton";
            this.ProcessTransactionButton.Size = new System.Drawing.Size(197, 36);
            this.ProcessTransactionButton.TabIndex = 5;
            this.ProcessTransactionButton.Text = "Withdraw";
            this.ProcessTransactionButton.UseVisualStyleBackColor = true;
            this.ProcessTransactionButton.Click += new System.EventHandler(this.ProcessTransactionButton_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 234);
            this.Controls.Add(this.ProcessTransactionButton);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.CashWithdrawalAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transactions";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CashWithdrawalAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CashWithdrawalAmount;
        private System.Windows.Forms.Label customerText;
        private System.Windows.Forms.Button ProcessTransactionButton;
    }
}

