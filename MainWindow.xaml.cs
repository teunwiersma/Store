using Store.ServiceReference2;
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
        
        MyServiceClient client = new MyServiceClient();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            string username;
            string password;
            //inlog functie hiero
            username = Name.Text;
            password = Password.Text;
            // test voor tweede window shit
            
            foreach(User user in client.GetUsers())
            {
                if(user.username == username && user.password == password)
                {
                    SecondWindow secondWindow = new SecondWindow();
                    this.Visibility = Visibility.Hidden;
                    secondWindow.Show();
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam of wachtwoord is verkeerd");
                    break;
                }
            }

            
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            // register functie hiero
            string newUsername = NewName.Text;

            char[] charArray = newUsername.ToCharArray();
            Array.Reverse(charArray);

            foreach(User user in client.GetUsers())
            {
                if(!(user.username == newUsername))
                {
                    client.InsertUser(newUsername, new string(charArray));
                    MessageBox.Show("Succesvol geregistreerd");
                    break;
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam bestaat al");
                    break;
                }
            }

        }
    }
}
