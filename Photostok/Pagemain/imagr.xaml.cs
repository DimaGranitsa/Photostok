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

namespace Photostok.Pagemain
{
    /// <summary>
    /// Логика взаимодействия для imagr.xaml
    /// </summary>
    public partial class imagr : Page
    {
        public imagr()
        {
            InitializeComponent();
            pan.ItemsSource = bd.COnnekc.imageEntities.image.ToList();
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var patient = ((sender as ListView).SelectedItem as bd.image);
            Photostok.Pagemain.infa a = new Pagemain.infa(patient);
          a.Show();
        }

        private void f_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
