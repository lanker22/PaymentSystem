using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Dashboard : Form
    {
        private ICustomer _customer;
        public Dashboard(ICustomer customer)
        {
            InitializeComponent();
            _customer = customer;
            WireUpForm();
        }

        private void WireUpForm()
        {
            _customer.Name = "Test";
            CustomerLabel.Text = _customer.Name;
            _customer.SavingsAccount.MakeDeposit(150M);
            _customer.CheckingAccount.MakeDeposit(183.56M);
            SavingsTransactionsRecord.DataSource = _customer.SavingsAccount.Transactions;
            CheckingTransactionsRecord.DataSource = _customer.CheckingAccount.Transactions;
            CheckingBalanceLabel.Text = string.Format("{0:C2}", _customer.CheckingAccount.Balance);
            SavingsBalanceLabel.Text = string.Format("{0:C2}", _customer.SavingsAccount.Balance);
        }

        private void RecordTransactionsButton_Click(object sender, EventArgs e)
        {
            var transactionsInput = new Transactions(_customer);
            transactionsInput.OnSuccessfulTransaction += TransactionsInput_OnSuccessfulTransaction;
        }

        private void TransactionsInput_OnSuccessfulTransaction(object sender, EventArgs e)
        {
            UpdateDashboardValues();
        }

        private void UpdateDashboardValues()
        {
            ToggleOverdraftText();
            UpdateDashboardTransactionRecords();
            UpdateDashboardBalanceLabels();
        }

        private void UpdateDashboardTransactionRecords()
        {
            SavingsTransactionsRecord.Invalidate();
            CheckingTransactionsRecord.Invalidate();
        }

        private void UpdateDashboardBalanceLabels()
        {
            CheckingBalanceLabel.Text = string.Format("{0:C2}", _customer.CheckingAccount.Balance);
            SavingsBalanceLabel.Text = string.Format("{0:C2}", _customer.SavingsAccount.Balance);
        }

        private void ToggleOverdraftText()
        {
            if (_customer.IsInOverdraft())
            {
                var overdraftText = $"Overdraft: {_customer.Overdraft}";
                OverdraftProtectionLabel.Text = overdraftText;
                OverdraftProtectionLabel.Visible = true;
            }
            else
            {
                OverdraftProtectionLabel.Visible = false;
            }
        }
    }
}
