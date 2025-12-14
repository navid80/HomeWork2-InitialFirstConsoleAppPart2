using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2.Exercise_2
{
    public class BankAccount
    {
        private int balance;

        public void Withdraw(double amount)
        {
            if (this.balance < amount)
            {
                Console.WriteLine("Not enough balance!");
            }
            else
            {
                this.balance -= (int)amount;
                Console.WriteLine($"Your balance has decreased : {amount}");
            }
        }

        public void Deposit(double amount)
        {
            this.balance += (int)amount;
            Console.WriteLine($"Your balance has increased : {amount}");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Your Balance Is : {this.balance}");
        }
    }
}
