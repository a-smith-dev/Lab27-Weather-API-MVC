using System;

namespace Lab27_API_MVC_combo.Models
{
    public class Time
    {
        public string layoutKey { get; set; }
        public string[] startPeriodName { get; set; }
        public DateTime[] startValidTime { get; set; }
        public string[] tempLabel { get; set; }
    }

}
