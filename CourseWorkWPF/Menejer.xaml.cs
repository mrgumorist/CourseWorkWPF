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
using System.Windows.Threading;
namespace CourseWorkWPF
{
    /// <summary>
    /// Interaction logic for Menejer.xaml
    /// </summary>
    public partial class Menejer : Window
    {
        ObservableCollection<User> ttt = new ObservableCollection<User>();
        
        public Menejer()
        {
            InitializeComponent();
        
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            try {
                foreach (var item in ttt)
                {
                    if (item.IsAccepted == true)
                    {
                        ttt.Remove(item);
                        GGG.ItemsSource = null;
                        if (ttt.Count != 0)
                            GGG.ItemsSource = ttt;
                        MessageBox.Show("User accepted");
                    }
                }
            }
            catch
            {

            }
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0,0,0,1);
            timer.Start();
            List<User> list= new List<User>();
            list.AddRange(Helper.users);
            foreach (var item in list)
            {
                if (item.Range!="Client" && item.Range != "Admin") {
                    if (item.IsAccepted==false)
                    {
                     
                        ttt.Add(item);
                    }
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
            InfoAllManajer menejer = new InfoAllManajer();
            menejer.ShowDialog();
            Close();
        }
    }
}
