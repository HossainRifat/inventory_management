using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

namespace Inventory_Management.Models
{
    public enum Roles
    {
        Admin = 1,
        Manager = 2,
        Member = 3
    }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsPhoneVerified { get; set; }
        public Roles Role { get; set; }

        private SqlConnection prepareConnection()
        {
            string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();

            return conn;
        }

        public User Login(string username, string password)
        {
            User user = new User();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = prepareConnection();
            cmd.CommandText = "spIM_LoginUser";
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if(reader.Read())
                {
                    user.Id = Convert.ToInt32(reader["ID"]);
                    user.Username = reader["Username"].ToString();
                    user.Name = reader["Name"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.Phone = reader["Phone"].ToString();
                    user.Status = Convert.ToInt16(reader["Status"]);
                    user.Role = (Roles)Convert.ToInt16(reader["Role"]);

                    return user;
                }

            }

            return null;
        }

        public List<User> UserList()
        {
            List<User> preparedData = new List<User>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = prepareConnection();
            cmd.CommandText = "spIM_LstUser";
            cmd.Parameters.Clear();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(reader["ID"]);
                    user.Name = reader["Name"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.Phone = reader["Phone"].ToString();
                    user.Status = Convert.ToInt16(reader["Status"]);
                    user.Role = (Roles)Convert.ToInt16(reader["Role"]);
                    preparedData.Add(user);
                }
            }

            return preparedData;
        }

    }
}