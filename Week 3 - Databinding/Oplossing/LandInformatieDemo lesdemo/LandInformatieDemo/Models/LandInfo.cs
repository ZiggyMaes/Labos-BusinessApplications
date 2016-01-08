using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LandInformatieDemo.Models
{
    public class LandInfo : INotifyPropertyChanged
    {
        public String LandNaam { get; set; }
        public String VlagURL { get; set; }
        private Boolean _isEuropees;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public Boolean IsEuropees
        {
            get { return _isEuropees; }
            set
            {
                if (value == _isEuropees) return;   //geen wijziging
                _isEuropees = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return LandNaam + " (Europees: " + IsEuropees + ")";
        }
    }
}



