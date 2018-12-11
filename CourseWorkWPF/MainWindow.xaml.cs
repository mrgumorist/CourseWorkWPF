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
            foreach (var item in Helper.users)
            {
                
                if(item.Login==Login.Text&&item.Password==Pass.Password)
                {
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
                            else if (item.Range == "Cook")
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("Your request in procces! Menejers will look it");
                        }
                    }
                    else
                    {
                        MessageBox.Show("YOU ARE BANNED");
                    }
                }
                else
                {
                    MessageBox.Show("Incorect login or password");

                }
            }
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
            Helper.Deserialize();
        }
    }
}
