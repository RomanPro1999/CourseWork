using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizeSystemWindowsForms.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public UserModel(string login, string password, string name,string surname,string email)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Email = email;
        }
        public UserModel(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public UserModel()
        {

        }
        public bool ModelIsValid()
        {

            if (Login == "" || Login == null || Password == "" || Password == null)
                return false;
            else
                return true;
        }
    }
}
