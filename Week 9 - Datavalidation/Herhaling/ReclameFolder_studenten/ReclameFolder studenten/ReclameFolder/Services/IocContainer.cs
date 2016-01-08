using ReclameFolder.Repositories;
using ReclameFolder.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameFolder.Services
{
    public class IocContainer
    {
        static IocContainer()
        {
            SimpleIoc.Default.Register<BedrijfRepository>(false);
            SimpleIoc.Default.Register<ReclameCampagneRepository>(false);
            SimpleIoc.Default.Register<ReclameCampagnesWindowViewModel>(false);
        }

        public static ReclameCampagnesWindowViewModel ReclameCampagnesWindowViewModel
        {
            get { return SimpleIoc.Default.GetInstance<ReclameCampagnesWindowViewModel>(); }
        }
        public static BedrijfRepository BedrijfRepository
        {
            get { return SimpleIoc.Default.GetInstance<BedrijfRepository>(); }
        }
        public static ReclameCampagneRepository ReclameCampagneRepository
        {
            get { return SimpleIoc.Default.GetInstance<ReclameCampagneRepository>(); }
        }
    }
}
