using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    public class Report
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ReportType { get; set; }

        public void GenerateReport()
        {
            // Code to generate a report
        }

        public void ExportReport()
        {
            // Code to export the report to a file
        }
    }

}
