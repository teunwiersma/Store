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
            string username = Name.Text;
            string password = Password.Text;
            //inlog functie hiero
            // test voor tweede window shit

            foreach(User user in client.GetUsers())
            {
                if(user.username.Equals(username) && user.password.Equals(password))
                {
                    SecondWindow secondWindow = new SecondWindow(username, user.bank);
                    secondWindow.username = username;
                    secondWindow.bank = user.bank;
                    this.Visibility = Visibility.Hidden;
                    secondWindow.Show();
                }
                
            }
                MessageBox.Show("Gebruikersnaam of wachtwoord is verkeerd");

        }

        private void Register(object sender, RoutedEventArgs e)
        {
            // register functie hiero
            string newUsername = NewName.Text;

            char[] charArray = newUsername.ToCharArray();
            Array.Reverse(charArray);

            if(!client.GetUsers().Any(x => x.username.Equals(newUsername)))
            {
                client.InsertUser(newUsername, new string(charArray));
                NewPassword.Content = "Your new password: " + new string(charArray);
                MessageBox.Show("Succesvol geregistreerd");
            }
            else
            {
                MessageBox.Show("Gebruikersnaam bestaat al");
            }
            

        }
    }
}
