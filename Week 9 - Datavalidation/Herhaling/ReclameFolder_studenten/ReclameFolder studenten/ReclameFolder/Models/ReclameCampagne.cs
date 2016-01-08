using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ReclameFolder.Models
{
    public class ReclameCampagne
    {
        public Bedrijf Bedrijf { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }
    }

}
