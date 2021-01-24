using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public interface IAccount
    {
        void DepositFunds(decimal withdrawal);
        void MakeDeposit(decimal deposit);
    }
}
