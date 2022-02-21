using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class GPSDetails
    {
        public decimal GoalAmount { get; set; }

        public string GoalName { get; set; }

        public decimal  Amountneededperyear { get; set; }

        public decimal AmountLefttoSave { get; set; }

        public int YearstoSave { get; set; }

        public approach PlanningApproach { get; set; }
    }

    public enum approach
    {
        Conservative, Current , Aggressive
    }
}
