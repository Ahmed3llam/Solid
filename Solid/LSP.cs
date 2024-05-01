using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class LSP
    {
        public class Account
        {
            public decimal Balance { get; protected set; }

            public virtual void Deposit(decimal amount)
            {
                Balance += amount;
            }

            public virtual void Withdraw(decimal amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient balance.");
                }
            }
        }

        public class SavingsAccount : Account
        {
            public decimal InterestRate { get; set; }

            public override void Withdraw(decimal amount)
            {
                //amount += 5.0m;
                base.Withdraw(amount);
            }
        }

    }
}
