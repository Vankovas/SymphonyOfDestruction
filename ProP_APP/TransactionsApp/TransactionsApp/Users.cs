using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionsApp
{
    class User
    {
        private int userId;
        private double balance;

        public int UserId { get { return userId; } }
        public double Balance { get { return balance; } }

        public User(int userId, double balance)
        {
            this.userId = userId;
            this.balance = balance;
        }

        public override string ToString()
        {
            return "User: " + userId + "\t\tBalance: " + balance + "€";
        }
    }
}
