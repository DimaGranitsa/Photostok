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
using System.Xml.Linq;

namespace Photostok.Pagemain
{
    /// <summary>
    /// Логика взаимодействия для busket.xaml
    /// </summary>
    public partial class busket : Page
    {
        public busket()
        {
            InitializeComponent();
            pan.ItemsSource = bd.COnnekc.photostok.BAsket.ToList();
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void rev()
        {
            pan.ItemsSource = bd.COnnekc.photostok.BAsket.ToList();
        }
        private void удалить_Click(object sender, RoutedEventArgs e)
        {
            var b = pan.SelectedItem as bd.BAsket;
            if(b != null)
            {
                bd.COnnekc.photostok.BAsket.Remove(b);
                bd.COnnekc.photostok.SaveChanges();
            }
            else
            {
                MessageBox.Show("net");
            }
            rev();



        }

        private void oplatit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
