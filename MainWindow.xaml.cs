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

namespace Store
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
        string username;
        string password;

        private void Login(object sender, RoutedEventArgs e)
        {
            //inlog functie hiero
            username = Name.Text;
            password = Password.Text;
            // test voor tweede window shit
            if (username == "admin" && password == "admin")
            {
                SecondWindow secondWindow = new SecondWindow();
                this.Visibility = Visibility.Hidden;
                secondWindow.Show();
            }
            
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            // register functie hiero
        }
    }
}
