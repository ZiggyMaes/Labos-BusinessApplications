using BALaboVoorbeeld.UWP.Pages;
using BALaboVoorbeeld.UWP.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALaboVoorbeeld.UWP.Services
{
    public class IocContainer
    {
        static IocContainer()
        {
            SimpleIoc.Default.Register<ApplicationViewModel>(false);
            SimpleIoc.Default.Register<ShowWeatherViewModel>(false);
            SimpleIoc.Default.Register<ShowWeatherPage>(false);
        }

        public static ShowWeatherPage ShowWeatherPage
        {
            get { return SimpleIoc.Default.GetInstance<ShowWeatherPage>(); }
        }
        public static ShowWeatherViewModel ShowWeatherViewModel
        {
            get { return SimpleIoc.Default.GetInstance<ShowWeatherViewModel>(); }
        }
        public static ApplicationViewModel ApplicationViewModel
        {
            get { return SimpleIoc.Default.GetInstance<ApplicationViewModel>(); }
        }
    }
}
