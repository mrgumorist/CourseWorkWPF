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
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        ObservableCollection<User> users = new ObservableCollection<User>();
        int selected = 0;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in Helper.users)
            {
                users.Add(item);
            }
            Nonff.ItemsSource = users;
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            if (Text1.Text != null && Text2.Text != null && Text3.Text != null)
            {
                User user = new User() { Name = Text1.Text , Login= Text2.Text, Password = Text3.Text, LastLogin=DateTime.Now};
                Helper.users.Add(user);
                MessageBox.Show("Succesfull added");
                users.Add(user);
                Text1.Text = "";
                Text2.Text = "";
                Text3.Text = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in users)
            {
                if((Nonff.SelectedItem  as User).Login==item.Login)
                {
                    try
                    {
                        users.Remove(item);
                        Helper.users.Remove(item);
                        MessageBox.Show("Seccesfull");
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
