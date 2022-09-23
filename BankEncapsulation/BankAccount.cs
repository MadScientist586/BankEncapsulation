using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double Balance = 0;
        public void Deposit(double userDepositAnswer)
        {
            Balance += userDepositAnswer;
        }
        public void Withdraw(double amountToWithdraw)
        {
            Balance -= amountToWithdraw;
        }
        public double GetBalance()
        {
            return Balance;
        }
    }
}
