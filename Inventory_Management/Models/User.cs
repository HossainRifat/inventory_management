using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public static User memeber1 = new User() { Id = 1, Username = "Jon", Email = "jon@gmail.com", Name = "Jon Doe", Role = Roles.Member };
        public static User memeber2 = new User() { Id = 2, Username = "Jane", Email = "jane@gmail.com", Name = "Jane Doe", Role = Roles.Member };
        public static User memeber3 = new User() { Id = 3, Username = "Jack", Email = "jack@gmail.com", Name = "Jack Doe", Role = Roles.Member };

        public static List<User> MemberList()
        {
            List<User> members = new List<User>()
            {
                User.memeber1,
                User.memeber2,
                User.memeber3
            };

            return members;
        }

    }
}