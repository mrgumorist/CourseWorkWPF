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
    /// Interaction logic for Phones.xaml
    /// </summary>
    public partial class Phones : Window
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>()
            {
            new Product() {Price =100, Name="Xiaomi", Versio="1.0" },

            new Product() {Price =110, Name="Xiaomi", Versio="2.0" },

             new Product() {Price =120, Name="Xiaomi", Versio="3.0" },

             new Product() {Price =130, Name="Xiaomi", Versio="3.1" },

             new Product() {Price =200, Name="Xiaomi", Versio="4.0" }

             };
        User user;
        public Phones(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Hide();
        //    NoutBooks phones = new NoutBooks();
        //    phones.ShowDialog();
        //    this.Close();
        //}
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
                item.Photo = "Res/Phones/" + $"{i}" + ".jpg";
                i++;
            }
            Display.ItemsSource = products;
            

            //foreach (var item in Display.Items)
            //{
            //    foreach (var item2 in products)
            //    {
            //        if((item as Product).Name==item2.Name)
            //        {
                       
            //            (item as ListViewItem).ToolTip = null;
            //        }
            //    }
            //}
            
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
    public class Product
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Versio { get; set; }
        public string Photo { get; set; }
    }
}
