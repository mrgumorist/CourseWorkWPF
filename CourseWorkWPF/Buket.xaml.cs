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
    /// Interaction logic for Buket.xaml
    /// </summary>
    public partial class Buket : Window
    {
        private User user;
        ObservableCollection<Product> products = new ObservableCollection<Product>();
        public Buket(User user)
        {
            this.user = user;
            products = user.productss;
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
            Display.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int price = 0;
            foreach (var item in user.productss)
            {
                user.productssDelivered.Add(item);
                price += item.Price;
            }
            user.productss.Clear();
            user.DeliverStatus = 1;
            
            MessageBox.Show("Products are in proccesing! Thanks!"+Environment.NewLine+"Your Total: "+price+"$");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            user.productss.Clear();
            MessageBox.Show("Succesfull canceled");

        }
    }
}
