using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    /// <summary>
    ///     Bank account with the ability to deposit and withdraw funds. 
    ///     <param name="Transactions">List of withdrawals and deposits made</param>
    ///     <param name="Balance">Funds left on the account</param>
    /// </summary>
    public class Account : IAccount
    {
        public event EventHandler InvalidTransactionRequest;
        public event EventHandler TransactionCompleted;
        public List<string> Transactions { get; private set; }
        public decimal Balance { get; private set; }

        public Account()
        {
            Transactions = new List<string>();
        }
        /// <summary>
        /// Attempt to withdraw the specified amount from the account Balance.
        /// </summary>
        /// <param name="withdrawal"></param>
        public void DepositFunds(decimal withdrawal)
        {
            // Determine if there are enough funds to fulfill the withdrawal request
            // If not, fire InvalidTransactionRequest event
            if(CheckIfAccountHasSufficientFunds(withdrawal) == false)
            {
                InvalidTransactionRequest?.Invoke(this, EventArgs.Empty);
            }
            // Or if there are sufficient funds, reduce balance by withdrawal amount and fire TransactionCompleted event
            else
            {

                var withdrawalCurrencyFormat = string.Format("{0:C2}", withdrawal);
                var transactionRecord = $"Withdrawal of {withdrawalCurrencyFormat}";
                Transactions.Add(transactionRecord);
                Balance -= withdrawal;
                TransactionCompleted(this, EventArgs.Empty);
            }
        }

        private bool CheckIfAccountHasSufficientFunds(decimal requestedWithdrawalAmount)
        {
            return Balance - requestedWithdrawalAmount< 0;
        }

        public void MakeDeposit(decimal deposit)
        {
            Balance += deposit;
        }
    }
}
