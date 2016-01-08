using LandInformatieDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace LandInformatieDemo.Controls
{
    public sealed partial class ctlLandInfo : UserControl
    {
        public LandInfo Land { get; private set; }
        public ctlLandInfo()
        {
            this.InitializeComponent();
        }
        public void ToonLandInfo(LandInfo land)
        {
            Land = land;
            imgLand.Source = new BitmapImage(new Uri(land.VlagURL));
            txbLand.Text = land.LandNaam;
            chkEuropees.IsChecked = land.IsEuropees;
        }

        private void chkEuropees_CheckedChanged(object sender, RoutedEventArgs e)
        {
            Land.IsEuropees = chkEuropees.IsChecked.Value;
        }
    }
}
