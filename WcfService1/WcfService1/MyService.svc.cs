using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyService.svc or MyService.svc.cs at the Solution Explorer and start debugging.
    public class MyService : IMyService
    {
        //var connString = "Host=localhost;Username=postgres;Password=1234;Database=net";

        

        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();
            User user;
            try
            {
                var connString = "Host=localhost;Username=postgres;Password=1234;Database=net";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    
                    using (var cmd = new NpgsqlCommand("SELECT id, username, password, bank FROM users", conn))
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3));
                            userList.Add(user);
                            
                            
                        }
                    conn.Close();
                }
            }
            catch(Exception msg)
            {
                Console.WriteLine(msg.ToString());
            }

            return userList;
            
        }

        public void InsertUser(string username, string password)
        {
            try
            {
                var connString = "Host=localhost;Username=postgres;Password=1234;Database=net";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();


                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO users(username, password, bank) values(@u, @p, @b)";
                        cmd.Parameters.AddWithValue("u", username);
                        cmd.Parameters.AddWithValue("p", password);
                        cmd.Parameters.AddWithValue("b", 100);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.ToString());
            }
        }
    }
}
