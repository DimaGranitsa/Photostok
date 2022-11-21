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
    /// Логика взаимодействия для vhod.xaml
    /// </summary>
    public partial class vhod : Page
    {
        public static bd.User NAme ;
        public vhod()
        {
            InitializeComponent();
        }

        private void f_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void p_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void vhode_Click(object sender, RoutedEventArgs e)
        {
            //p.Navigate(new Pagemain.lik());
            if (string.IsNullOrEmpty(log.Text) || string.IsNullOrEmpty(pass.Password) )
            {
                MessageBox.Show("ved");
            }
            else
            {
                var a = bd.COnnekc.photostok.User.Where(z => z.Login == log.Text && z.password == pass.Password).FirstOrDefault();
                if (a != null)
                {
                    p.Navigate(new lik());
                }
                
                else
                {
                    MessageBox.Show("pass  yt");
                }
               
            }   
                
                 
           

        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            f.Navigate(new Pagemain.reg());
        }

        private void назад_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
