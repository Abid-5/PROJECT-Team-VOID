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
        public decimal Budget { get; set; }

        public override string ToString()
        {
            return $"{Category} - {Budget} {Amount}";
        }
    }
}
