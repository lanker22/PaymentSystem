using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    ///     Customer with associated Checking and Savings accounts.
    /// </summary>
    public class Customer : ICustomer
    {
        public string Name { get; set; }

        private IAccount _checkingAccount;

        private IAccount _savingsAccount;

        public Customer(IAccount checkingAccount, IAccount savingsAccount)
        {
            _checkingAccount= checkingAccount;
            _savingsAccount= savingsAccount;
        }
    }
}
