using Photostok.bd;
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
        public static bd.Image image;
        public infa(bd.Image image)
        {
            InitializeComponent();
            this.DataContext = image;
            bd.Image w;
            w = image;
        }

        private void vkar_Click(object sender, RoutedEventArgs e)
        {
            bd.BAsket q = new bd.BAsket()
            {
                namefotograf1 = nameq.Text,
                image1 = IPicture.ToString(),
                Prise = priceq.Text,
                User1 = nameq.Text,
                  };
            bd.COnnekc.photostok.BAsket.Add(q);
            bd.COnnekc.photostok.SaveChanges();
        }
    }
}
