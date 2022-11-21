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
    /// Логика взаимодействия для Histor.xaml
    /// </summary>
    public partial class Histor : Page
    {
        public Histor()
        {
            InitializeComponent();
            pan.ItemsSource = bd.COnnekc.photostok.History.ToList();
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
