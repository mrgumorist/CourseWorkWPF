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
    /// Interaction logic for NoutBooks.xaml
    /// </summary>
    public partial class NoutBooks : Window
    {
        User user;
        ObservableCollection<Product> products = new ObservableCollection<Product>()
            {
            new Product() {Price =1020, Name="Lenovo", Versio="Z3" },

            new Product() {Price =1130, Name="Lenovo", Versio="R5" },

             new Product() {Price =1520, Name="Lenovo", Versio="R3" },

             new Product() {Price =1430, Name="Lenovo", Versio="G6" },

             new Product() {Price =2500, Name="Lenovo", Versio="A1" }

             };
        public NoutBooks(User user)
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

        private void Mouses(object sender, RoutedEventArgs e)
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
            
            int i = 0;
            foreach (var item in products)
            {
                item.Photo = "Res/Noteed/" + $"{i}" + ".png";
                i++;
            }
            Display.ItemsSource = products;
        }

        private void Display_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < products.Count(); i++)
                if (Display.SelectedItem == products[i])
                {
                    user.productss.Add(products[i]);
                    MessageBox.Show("Succesfull added in your baket");
                }
        }
    }
}
