using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPXTool.Models
{
    public class TrkPt : ModelBaseClass
    {
        private DateTime _tijdstipdt;
        public DateTime Tijdstip { get; set; }
        public string tijdstip
        {
            get { return Tijdstip.ToString("yyyy MM dd HH:mm:ss", null); }
            set { Tijdstip = DateTime.ParseExact(value, "yyyy MM dd HH:mm:ss", null); }
        }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
