using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarkBalisi.ThirdQuarterlyAssessment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> municipalities = new List<string>()
            {
                "Dinalupihan" ,
                "Davao City" ,
                "Angeles City" ,
                "Brooke's Point" ,
                "Olongapo City" ,
            };

            cboMunicipalities.ItemsSource = municipalities;
        }

        private void cboMunicipalities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboMunicipalities.SelectedIndex == 0)
            {
                Map.Center = new Microsoft.Maps.MapControl.Location(14.8781, 120.4546);
                Map.ZoomLevel = 13;
            }
            if (cboMunicipalities.SelectedIndex == 1)
            {
                Map.Center = new Microsoft.Maps.MapControl.Location(7.13009927880163, 125.42804470063739);
                Map.ZoomLevel = 10;
            }
            if (cboMunicipalities.SelectedIndex == 2)
            {
                Map.Center = new Microsoft.Maps.MapControl.Location(15.160460231120194, 120.60047399746576);
                Map.ZoomLevel = 13;
            }
            if (cboMunicipalities.SelectedIndex == 3)
            {
                Map.Center = new Microsoft.Maps.MapControl.Location(8.827339952813013, 117.83041789939554);
                Map.ZoomLevel = 11;
            }
            if (cboMunicipalities.SelectedIndex == 4)
            {
                Map.Center = new Microsoft.Maps.MapControl.Location(14.834821290849918, 120.2820978394843);
                Map.ZoomLevel = 13;
            }
        }
    }
}
