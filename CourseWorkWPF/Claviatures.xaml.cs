using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CourseWorkWPF
{
    /// <summary>
    /// Interaction logic for Claviatures.xaml
    /// </summary>
    public partial class Claviatures : Window
    {
        User user;
        public Claviatures(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void Golovna(object sender, RoutedEventArgs e)
        {
            Hide();
            Client phones = new Client(user);
            phones.ShowDialog();
            this.Close();
        }

        private void Notebooks(object sender, RoutedEventArgs e)
        {
            Hide();
            NoutBooks phones = new NoutBooks(user);
            phones.ShowDialog();
            this.Close();
        }

        private void Mousses(object sender, RoutedEventArgs e)
        {
            Hide();
            Mouses phones = new Mouses(user);
            phones.ShowDialog();
            this.Close();
        }

        private void Clava(object sender, RoutedEventArgs e)
        {
            Hide();
            Claviatures phones = new Claviatures(user);
            phones.ShowDialog();
            this.Close();
        }

        private void Bukett(object sender, RoutedEventArgs e)
        {

            Hide();
            Buket phones = new Buket(user);
            phones.ShowDialog();
            this.Close();
        }

        private void Phone(object sender, RoutedEventArgs e)
        {
            Hide();
            Phones phones = new Phones(user);
            phones.ShowDialog();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Product> products = new ObservableCollection<Product>()
            {
            new Product() {Price =100, Name="MSi", Versio="1.0" },

            new Product() {Price =110, Name="MSi", Versio="2.0" },

             new Product() {Price =120, Name="MSi", Versio="3.0" },

             new Product() {Price =130, Name="MSi", Versio="3.1" },

             new Product() {Price =200, Name="MSi", Versio="4.0" }

             };
            int i = 0;
            foreach (var item in products)
            {
                item.Photo = "Res/Clavass/" + $"{i}" + ".png";
                i++;
            }
            Display.ItemsSource = products;
        }
    }
}
