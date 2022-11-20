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
using System.Windows.Shapes;

namespace Photostok.Pagemain
{
    /// <summary>
    /// Логика взаимодействия для infa.xaml
    /// </summary>
    public partial class infa : Window
    {
        public static bd.image image;
        public infa(bd.image image)
        {
            InitializeComponent();
            this.DataContext = image;
            bd.image w;
            w = image;
        }

        private void vkar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
