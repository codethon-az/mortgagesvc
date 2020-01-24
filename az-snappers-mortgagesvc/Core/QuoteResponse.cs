using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class QuoteResponse
    {
        public string  PropertyId    { get; set; }
        public string UserId { get; set; }
        public string RateofInterest { get; set; }
        public bool IsPreApproved { get; set; }
        public decimal DownPayment { get; set; }
        public string AccountNumber { get; set; }
        public decimal MonthlyEMI { get; set; }

    }
}
