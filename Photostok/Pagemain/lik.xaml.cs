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
    /// Логика взаимодействия для lik.xaml
    /// </summary>
    public partial class lik : Page
    {
        private lik _page1;

        public lik()
        {
            InitializeComponent();
            this.DataContext = vhod.NAme ;

        }

        private void his_Click(object sender, RoutedEventArgs e)
        {
            f.Navigate(new Pagemain.Histor());
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
          
            NavigationService.Navigate(_page1);
        }

        private void dobavit_Click(object sender, RoutedEventArgs e)
        {
            f.Navigate(new Pagemain.dobavitphoto());
        }

        private void f_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
