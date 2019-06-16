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

        
        public User(int id, string username, string password, double bank)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.bank = bank;
        }
    }
}
