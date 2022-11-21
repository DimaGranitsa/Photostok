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
    /// Логика взаимодействия для mainPAge.xaml
    /// </summary>
    public partial class mainPAge : Page
    {
        public mainPAge()
        {
            InitializeComponent();
        }

        private void foto_Click(object sender, RoutedEventArgs e)
        {
            f.Navigate(new Pagemain.imagr());
        }

        private void redact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lic_Click(object sender, RoutedEventArgs e)
        {
            f.Navigate(new Pagemain.vhod());
        }

        private void kar_Click(object sender, RoutedEventArgs e)
        {
            f.Navigate(new Pagemain.busket());
        }

        private void f_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
