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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWorkWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //todo logginning
            bool found = false;
            foreach (var item in Helper.users)
            {
                if(item.Login==Login.Text&&item.Password==Pass.Password)
                {
                    found = true;
                    if(item.IsBanned==false)
                    {
                        if(item.IsAccepted==true)
                        {
                                
                            if(item.Range== "Deliver")
                            {

                            }
                            else if(item.Range == "Manager")
                            {

                            }
                            else if (item.Range == "Admin")
                            {

                            }
                            else if (item.Range == "Client")
                            {
                                Hide();
                                Client client = new Client(item);
                                client.ShowDialog();
                                Show();

                            }
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Your request in procces! Menejers will look it");
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("YOU ARE BANNED");
                        break;
                    }
                }
                else
                {
                    found = false;
                }                   
            }
            if(found==false)
            {
                MessageBox.Show("Account not found");
            }
            Login.Text = null;
            Pass.Password = null;
        }

        private void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            //register
            
            Hide();
            Register reg = new Register();
            reg.ShowDialog();
            Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Helper.Serialize();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Helper.Deserialize();
        }
    }
}
