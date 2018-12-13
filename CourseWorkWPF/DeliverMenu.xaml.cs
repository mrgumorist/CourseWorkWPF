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
    /// Interaction logic for DeliverMenu.xaml
    /// </summary>
    public partial class DeliverMenu : Window
    {
        ObservableCollection<User> users = new ObservableCollection<User>();
        User user;
        public DeliverMenu(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in Helper.users)
            {
                if(item.Range=="Client"&&item.productssDelivered!=null)
                {
                    users.Add(item);
                }
            }
            Display.ItemsSource = users;
        }

        private void Display_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < users.Count(); i++)
            {
                if(Display.SelectedItem==users[i])
                {
                    user.completedusers.Add(users[i]);
                    users[i].productssDelivered.Clear();
                    MessageBox.Show("Succesfull deleted");
                    users.RemoveAt(i);
                }
            }
        }
    }
}
