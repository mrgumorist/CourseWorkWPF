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

namespace CourseWorkWPF
{
    /// <summary>
    /// Interaction logic for NoutBooks.xaml
    /// </summary>
    public partial class NoutBooks : Window
    {
        public NoutBooks()
        {
            InitializeComponent();
        }
        private void Golovna(object sender, RoutedEventArgs e)
        {
            Hide();
            Client phones = new Client();
            phones.ShowDialog();
            this.Close();
        }

        private void Notebooks(object sender, RoutedEventArgs e)
        {
            Hide();
            NoutBooks phones = new NoutBooks();
            phones.ShowDialog();
            this.Close();
        }

        private void Mouses(object sender, RoutedEventArgs e)
        {
            Hide();
            Mouses phones = new Mouses();
            phones.ShowDialog();
            this.Close();
        }

        private void Clava(object sender, RoutedEventArgs e)
        {
            Hide();
            Claviatures phones = new Claviatures();
            phones.ShowDialog();
            this.Close();
        }

        private void Bukett(object sender, RoutedEventArgs e)
        {

            Hide();
            Buket phones = new Buket();
            phones.ShowDialog();
            this.Close();
        }

        private void Phone(object sender, RoutedEventArgs e)
        {
            Hide();
            Phones phones = new Phones();
            phones.ShowDialog();
            this.Close();
        }
    }
}
