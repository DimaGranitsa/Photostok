using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Photostok.bd;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;


namespace Photostok.Pagemain
{
    /// <summary>
    /// Логика взаимодействия для dobavitphoto.xaml
    /// </summary>
    public partial class dobavitphoto : Page
    {
        byte[] image1 = null;
        bd.photoq b = new bd.photoq();

        public dobavitphoto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            bd.photoq q = new bd.photoq()
            {
                name = namephoto.Text,
                nameFhotograf = namefotogrof.Text,
                teretory = teretory.Text,
                iso = Isoo.Text,
                diofragma = diofrag.Text,
                vadergka = vadergka.Text,
                price = Cena.Text,
                image = image1
            };
            bd.COnnekc.photostok.photoq.Add(q);
            bd.COnnekc.photostok.SaveChanges();
        }

        private void soh_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(ofd.FileName);
                bitmapImage.EndInit();
                image1 = File.ReadAllBytes(ofd.FileName);
                IPicture.Source = bitmapImage;
            }
        }
    }
}
