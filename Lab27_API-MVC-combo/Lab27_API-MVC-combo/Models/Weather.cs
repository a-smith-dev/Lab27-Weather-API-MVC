using System;
using System.Text.Json.Serialization;

namespace Lab27_API_MVC_combo.Models
{
    public class Weather
    {
        public string OperationalMode { get; set; }
        public string SrsName { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationDateLocal { get; set; }
        public string ProductionCenter { get; set; }
        public string Credit { get; set; }
        public string MoreInformation { get; set; }
        public Location Location { get; set; }
        public Time Time { get; set; }
        public Data Data { get; set; }
        public CurrentObservation CurrentObservation { get; set; }
    }

}
