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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Page
    {
        public reg()
        {
            InitializeComponent();
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            bd.User q = new bd.User()
            {
               Login = log.Text,
               password = pass.Text,
               NAme = name.Text,

            };
            bd.COnnekc.photostok.User.Add(q);
            bd.COnnekc.photostok.SaveChanges();
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
