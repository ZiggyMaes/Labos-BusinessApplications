using ReclameFolder.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameFolder.Repositories
{
    public class ReclameCampagneRepository
    {
        private ObservableCollection<ReclameCampagne> _reclameCampagnes = new ObservableCollection<ReclameCampagne>();
        public ObservableCollection<ReclameCampagne> ReclameCampagnes
        {
            get { return _reclameCampagnes; }
        }
        public void AddReclameCampagne(ReclameCampagne reclameCampagne)
        {
            ReclameCampagnes.Add(reclameCampagne);
        }

        public ReclameCampagneRepository()
        {
            Bedrijf howest = SimpleIoc.Default.GetInstance<BedrijfRepository>().Bedrijven[0];
            ReclameCampagnes.Add(new ReclameCampagne()
                { Bedrijf = howest, Budget = 1000, StartDatum = DateTime.Now,
                EindDatum = DateTime.Now.AddMonths(1) });
        }
    }
}
