using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class User
    {
        public int User_id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Permission { get; set; }
        public string Password { get; set; }


        public User()
        {
            Login = "";
            Password = "";
            FirstName = "";
            LastName = "";
            PhoneNumber = "";
            EmailAddress = "";
            User_id = 0;
            Permission = 0;
        }

        public User(string login, string password, string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            User_id = 0;
            Permission = 0;
        }
        public User(string login, string password, string firstName, string lastName, string phoneNumber, string emailAddress, int user_id, int permission)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            User_id = user_id;
            Permission = permission;
        }
    }
    

}
