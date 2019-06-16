using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class Users
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        private static Users CurrnetUser;

        public void setCurrnetUser(Users u) {
            CurrnetUser = u;
        }
        public Users getCurrnetUser()
        {
            return CurrnetUser;
        }

        public Users CheckLogin(string u, string p)
        {
            foreach (Users item in this.DSUsers()) {
                if (item.Password == p && item.Username == u)
                    return item;
            }
            return new Users();
        }

        public List<Users> DSUsers() {
            List<Users> lu = new List<Users>();
            lu.Add(new Users("admin", "123456", 
                "admin", "abcgmail.com", "123456789"));

            return lu;
        }
        
        public Users(string username, 
            string password, 
            string name, 
            string email, 
            string phone)
        {
            Username = username;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
        }

        public Users()
        {
        }



        public override bool Equals(object obj)
        {
            var users = obj as Users;
            return users != null &&
                   Username == users.Username &&
                   Password == users.Password &&
                   Name == users.Name &&
                   Email == users.Email &&
                   Phone == users.Phone;
        }
    }
}
