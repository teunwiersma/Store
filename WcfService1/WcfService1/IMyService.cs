using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{

    [ServiceContract]
    public interface IMyService
    {

        [OperationContract]
        List<User> GetUsers();

        [OperationContract]
        void InsertUser(string username, string password);

        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        void InsertProductToUser(string username, string product);

        [OperationContract]
        User findUser(string username);

        [OperationContract]
        Product findProduct(string productName);

        [OperationContract]
        List<Product> GetProductsByUser(string username);
    }

    [DataContract]
    public class Product
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public double price { get; set; }
        [DataMember]
        public int amount { get; set; }

        public Product(int id, string name, double price, int amount)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.amount = amount;
        }
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public double bank { get; set; }

        public User() { }

        public User(int id, string username, string password, double bank)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.bank = bank;
        }
    }
}
