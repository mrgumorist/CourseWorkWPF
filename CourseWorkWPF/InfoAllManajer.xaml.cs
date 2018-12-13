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
    /// Interaction logic for InfoAllManajer.xaml
    /// </summary>
    public partial class InfoAllManajer : Window
    {
        ObservableCollection<User> ttt = new ObservableCollection<User>();
        public InfoAllManajer()
        {
            InitializeComponent();
        }
       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<User> list = new List<User>();
            list.AddRange(Helper.users);
            foreach (var item in list)
            {
                if (item.Range != "Client" )
                {
                  
                       
                        ttt.Add(item);
                   
                }
            }
            try
            {
                GGG.ItemsSource = ttt;
            }
            catch
            {
                MessageBox.Show("List error");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Menejer menejer = new Menejer();
            menejer.ShowDialog();
            Close();
        }
    }
}
