using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense
{
    public class Expense
    {
        public string Category { get; set; }
        public decimal Amount { get; set; }

        public Expense(string category, decimal amount)
        {
            Category = category;
            Amount = amount;
        }
    }
}
