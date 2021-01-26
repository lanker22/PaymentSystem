
namespace WinFormsUI
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SavingsTransactionsRecord = new System.Windows.Forms.ListBox();
            this.CheckingTransactionsRecord = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OverdraftProtectionLabel = new System.Windows.Forms.Label();
            this.RecordTransactionsButton = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CheckingBalanceLabel = new System.Windows.Forms.Label();
            this.SavingsBalanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Savings Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checking Transactions";
            // 
            // SavingsTransactionsRecord
            // 
            this.SavingsTransactionsRecord.FormattingEnabled = true;
            this.SavingsTransactionsRecord.ItemHeight = 15;
            this.SavingsTransactionsRecord.Location = new System.Drawing.Point(313, 153);
            this.SavingsTransactionsRecord.Name = "SavingsTransactionsRecord";
            this.SavingsTransactionsRecord.Size = new System.Drawing.Size(161, 184);
            this.SavingsTransactionsRecord.TabIndex = 2;
            // 
            // CheckingTransactionsRecord
            // 
            this.CheckingTransactionsRecord.FormattingEnabled = true;
            this.CheckingTransactionsRecord.ItemHeight = 15;
            this.CheckingTransactionsRecord.Location = new System.Drawing.Point(532, 153);
            this.CheckingTransactionsRecord.Name = "CheckingTransactionsRecord";
            this.CheckingTransactionsRecord.Size = new System.Drawing.Size(167, 184);
            this.CheckingTransactionsRecord.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Banking Demo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Checking Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Savings Balance";
            // 
            // OverdraftProtectionLabel
            // 
            this.OverdraftProtectionLabel.AutoSize = true;
            this.OverdraftProtectionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OverdraftProtectionLabel.ForeColor = System.Drawing.Color.Red;
            this.OverdraftProtectionLabel.Location = new System.Drawing.Point(313, 32);
            this.OverdraftProtectionLabel.Name = "OverdraftProtectionLabel";
            this.OverdraftProtectionLabel.Size = new System.Drawing.Size(349, 21);
            this.OverdraftProtectionLabel.TabIndex = 8;
            this.OverdraftProtectionLabel.Text = "You had an overdraft protection transfer of £0.00";
            this.OverdraftProtectionLabel.Visible = false;
            // 
            // RecordTransactionsButton
            // 
            this.RecordTransactionsButton.Location = new System.Drawing.Point(12, 281);
            this.RecordTransactionsButton.Name = "RecordTransactionsButton";
            this.RecordTransactionsButton.Size = new System.Drawing.Size(124, 65);
            this.RecordTransactionsButton.TabIndex = 9;
            this.RecordTransactionsButton.Text = "Record Transactions";
            this.RecordTransactionsButton.UseVisualStyleBackColor = true;
            this.RecordTransactionsButton.Click += RecordTransactionsButton_Click;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(187, 140);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(50, 15);
            this.CustomerLabel.TabIndex = 10;
            this.CustomerLabel.Text = "<none>";
            // 
            // CheckingBalanceLabel
            // 
            this.CheckingBalanceLabel.AutoSize = true;
            this.CheckingBalanceLabel.Location = new System.Drawing.Point(187, 190);
            this.CheckingBalanceLabel.Name = "CheckingBalanceLabel";
            this.CheckingBalanceLabel.Size = new System.Drawing.Size(34, 15);
            this.CheckingBalanceLabel.TabIndex = 11;
            this.CheckingBalanceLabel.Text = "£0.00";
            // 
            // SavingsBalanceLabel
            // 
            this.SavingsBalanceLabel.AutoSize = true;
            this.SavingsBalanceLabel.Location = new System.Drawing.Point(187, 242);
            this.SavingsBalanceLabel.Name = "SavingsBalanceLabel";
            this.SavingsBalanceLabel.Size = new System.Drawing.Size(34, 15);
            this.SavingsBalanceLabel.TabIndex = 12;
            this.SavingsBalanceLabel.Text = "£0.00";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SavingsBalanceLabel);
            this.Controls.Add(this.CheckingBalanceLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.RecordTransactionsButton);
            this.Controls.Add(this.OverdraftProtectionLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckingTransactionsRecord);
            this.Controls.Add(this.SavingsTransactionsRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Transactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox SavingsTransactionsRecord;
        private System.Windows.Forms.ListBox CheckingTransactionsRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OverdraftProtectionLabel;
        private System.Windows.Forms.Button RecordTransactionsButton;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label CheckingBalanceLabel;
        private System.Windows.Forms.Label SavingsBalanceLabel;
    }
}