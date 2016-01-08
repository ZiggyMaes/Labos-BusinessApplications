using ReclameFolder.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameFolder.Repositories
{
    public class BedrijfRepository
    {
        private ObservableCollection<Bedrijf> _bedrijven = new ObservableCollection<Bedrijf>();
        public ObservableCollection<Bedrijf> Bedrijven
        {
            get { return _bedrijven; }
        }
        public void AddBedrijf(Bedrijf bedrijf)
        {
            Bedrijven.Add(bedrijf);
        }

        public BedrijfRepository()
        {
            Bedrijven.Add(new Bedrijf()
            {
                Naam = "HOWEST",
                Description = "Hogeschool West-Vlaanderen",
                Email = "email",
                URL = "url"
            });
        }
    }
}
