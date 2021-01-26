using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Transactions : Form
    {
        public event EventHandler OnSuccessfulTransaction;

        private ICustomer _customer;
        public Transactions(ICustomer customer)
        {
            _customer = customer;
            InitializeComponent();
            customerText.Text = customer.Name;
            Show();
        }

        private void ProcessTransactionButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customer.CashWithdrawal(CashWithdrawalAmount.Value);
                Hide();
                OnSuccessfulTransaction(this, EventArgs.Empty);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
