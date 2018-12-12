using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        private bool notexit(string login)
        {
            List<User> list = new List<User>();
            list.AddRange(Helper.users);
            if(list.Count !=0)
            {
                foreach (var item in list)
                {
                    if(login==item.Login)
                    {
                        return false;

                    }
                }
            }
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pattern = @"^\p{Lu}[a-z]{1,9}$";

            int errror =0;
            List<string> errrors = new List<string>();
            if(Login.Text.Count()>=4 && notexit(Login.Text))
            {
                if(Password.Password.Count()>=4)
                {
                    if (Regex.IsMatch(Name.Text, pattern))
                    {
                        if (Regex.IsMatch(Surname.Text, pattern))
                        {
                            if(comboBox.SelectedIndex!=-1)
                            {
                                if(Fukk.SelectedDate!=null)
                                {
                                    User user = new User();
                                   if (comboBox.Text!= "Client")
                                   {
                                        user.IsAccepted = false;
                                   }
                                   else
                                   {
                                        user.IsAccepted = true;
                                    }
                                    user.IsBanned = false;
                                    user.dateOfBith= Fukk.SelectedDate.Value;
                                    user.Range = comboBox.Text;
                                    user.Name = Name.Text;
                                    user.Surname = Surname.Text;
                                    user.Login = Login.Text;
                                    user.Password = Password.Password;
                                    MessageBox.Show("Succesfull");
                                    Helper.users.Add(user);
                                    Close();
                                }
                                else
                                {
                                    errrors.Add("Please! Choose correct DateOfBith");
                                    errror++;


                                }
                            }
                            else
                            {
                                errrors.Add("Please! Choose correct range");
                                errror++;
                            }
                        }
                        else
                        {
                            errrors.Add("You can't add this Surname! It's wrong. Example: Smirnov");
                            errror++;
                        }
                    }
                    else
                    {
                        errrors.Add("You can't add this Name! It's wrong. Example: John");
                        errror++;
                    }
                }
                else
                {
                    errrors.Add("Size of pass can be only more than 4 symbols");
                    errror++;
                }
            }
            else
            {
                errrors.Add("Size of login can be only more than 4 symbols or login already using"); errror++;
            }
            if(errror!=0)
            {
                string dogCsv = string.Join(Environment.NewLine, errrors.ToArray());
                MessageBox.Show(dogCsv);
            }
        }
    }
}
