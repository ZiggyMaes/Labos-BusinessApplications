using StudentModulePuntApp.Models;
using StudentModulePuntApp.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StudentModulePuntApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<StudentModulePunt> _smp;

        public MainPage()
        {
            this.InitializeComponent();
        }
        private async void LoadScores()
        {
            _smp = await StudentModulePuntRepository.Entries();
            cmbStudent.ItemsSource = StudentEmail();
        }
        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            LoadScores();
        }
        private List<string> StudentEmail()
        {
            List<string> EmailList = new List<string>();
            //StudentModulePunt smp = new StudentModulePunt();
            foreach (StudentModulePunt s in _smp) EmailList.Add(s.Email);

            return EmailList;
        }
        private List<StudentModulePunt> StudentScore(string Emailadres)
        {
            List<StudentModulePunt> ScoreLijst = new List<StudentModulePunt>();
            foreach (StudentModulePunt student in _smp)
            {
                if (student.Email == Emailadres)  ScoreLijst.Add(student);
            }
            return ScoreLijst;
        }

        private void cmbStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string email = cmbStudent.SelectedItem.ToString();
            FillScoreList(StudentScore(email));
        }

        private void FillScoreList(List<StudentModulePunt> ScoreLijst)
        {
            lsbModules.ItemsSource = ScoreLijst;
        }
    }
}
