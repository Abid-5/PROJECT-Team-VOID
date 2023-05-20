using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense
{
    internal class Expense
    {
        public string Category { get; set; }
        public decimal Amount { get; set; }

        public Expense(string category, string description, decimal amount)
        {
            Category = category;
            Amount = amount;
        }
    }
}
