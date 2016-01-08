﻿using LandInformatieDemo.Models;
using LandInformatieDemo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LandInformatieDemo.ViewModels
{
    public class FilteringVM : INotifyPropertyChanged
    {
        public IEnumerable<LandInfo> GefilterdeLijst { get { return LandInfoRepository.Landen.Where(l => IsVoldoetAanFilter(l)); } }

        private Boolean IsVoldoetAanFilter(LandInfo l) { return (IsEuropaFilter && l.IsEuropees) || (IsNietEuropaFilter && !l.IsEuropees); }


        private bool _isEuropaFilter;
        public bool IsEuropaFilter
        {
            get { return _isEuropaFilter; }
            set
            {
                if (value == _isEuropaFilter) return;
                _isEuropaFilter = value;
                OnPropertyChanged();
                OnPropertyChanged("GefilterdeLijst");
            }
        }

        private bool _isNietEuropaFilter;
        public bool IsNietEuropaFilter
        {
            get { return _isNietEuropaFilter; }
            set
            {
                if (value == _isNietEuropaFilter) return;
                _isNietEuropaFilter = value;
                OnPropertyChanged();
                OnPropertyChanged("GefilterdeLijst");
            }
        }
        #region "property changed"
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}