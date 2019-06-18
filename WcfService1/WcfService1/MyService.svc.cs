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
        string connString = "Host=localhost;Username=postgres;Password=1234;Database=net";


        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();
            User user;
            try
            {
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

        public List<Product> GetProducts()
        {
            List<Product> productList = new List<Product>();
            Product product;
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();


                    using (var cmd = new NpgsqlCommand("SELECT id, name, price, amount FROM product", conn))
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            product = new Product(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3));
                            productList.Add(product);


                        }
                    conn.Close();
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.ToString());
            }

            return productList;

        }

        public void InsertUser(string username, string password)
        {
            try
            {
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

        public void InsertProductToUser(string username, string product)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();


                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO product_user(product_id, user_id) values(@p, @u)";
                        cmd.Parameters.AddWithValue("p", findProduct(product).id);
                        cmd.Parameters.AddWithValue("u", findUser(username).id);
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

        public User findUser(string username)
        {
            User user = null;
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();


                    using (var cmd = new NpgsqlCommand("SELECT id, username, password, bank FROM users where username = '" + username + "'", conn))
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3));
                        }
                    conn.Close();
                }
                return user;
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.ToString());
            }
            return user;

        }

        public Product findProduct(string productName)
        {
            Product product = null;
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();


                    using (var cmd = new NpgsqlCommand("SELECT id, name, price, amount FROM product where name = '" + productName + "'", conn))
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            product = new Product(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3));
                        }
                    conn.Close();
                }

                return product;
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.ToString());
            }
            return product;

        }

        public List<Product> GetProductsByUser(string username)
        {
            List<Product> productList = new List<Product>();
            Product product;
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();


                    using (var cmd = new NpgsqlCommand("SELECT product_id, user_id, product.name, product.price ,product.amount from users, product, product_user where product_id = product.id and user_id = users.id and users.username = '" + username + "'", conn))
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            product = new Product(reader.GetInt32(0), reader.GetString(2), reader.GetDouble(3), reader.GetInt32(4));
                            productList.Add(product);


                        }
                    conn.Close();
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.ToString());
            }

            return productList;
        }

        public void UpdateMoney(double newBank, string username)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();


                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE users SET bank = " + newBank +" WHERE username ='" + username + "'" ;
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
