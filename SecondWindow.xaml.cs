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
using System.Windows.Shapes;

namespace Store
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        MyServiceClient client = new MyServiceClient();
        public string username { get; set; }
        public double bank { get; set; }



        public SecondWindow(string username, double bank)
        {
            this.username = username;
            this.bank = bank;
            InitializeComponent();
            callProducts();
            callInventory();
            MoneyLabel.Content = "Money left: " + bank;
        }

        private void callProducts()
        {
            foreach (Product product in client.GetProducts())
            {
                if(product.amount > 0)
                {
                    Products.Items.Add(product.name + ": " + product.price);
                }
            }
        }

        private void callInventory()
        {
            foreach(Product product in client.GetProductsByUser(username))
            {
                Inventory.Items.Add(product.name + ": " + product.price);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // koop button
            try
            {
                if (!Inventory.Items.Contains(Products.SelectedItem))
                {
                    char[] newDelimiter = new char[] { ':' };
                    string product = Products.SelectedItem.ToString();
                    string[] splitProduct = product.Split(newDelimiter);

                    Inventory.Items.Add(Products.SelectedItem);
                    client.InsertProductToUser(username, splitProduct[0]);
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Kies een product");
            }
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Opnieuw ophalen van voorraad en producten
            callInventory();
            Products.Items.Clear();
            callProducts();
        }
    }
}
