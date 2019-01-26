using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.Interface
{
    //Interface can be declared public or internal
    //By default interface are public
    //Access modifiers in interface : there are no acces modifiers and are always public
    //Interface support multiple inheritance
    interface IExample
    {
        decimal GetCheckingBalance(long checkingAcctNum);
        decimal GetSavingBalance(long savingAcctNum);
        bool TransferCheckingToSaving(decimal amount, long checkingAccountNum, long savingAccountNum);
    }
}

