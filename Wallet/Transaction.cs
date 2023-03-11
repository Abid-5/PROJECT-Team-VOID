using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public void AddTransaction()
        {
            // Code to add a new transaction
        }

        public void RemoveTransaction()
        {
            // Code to remove a transaction
        }

        public void UpdateTransaction()
        {
            // Code to update an existing transaction
        }
    }

}
