using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Client : User
    {

        public string Opinion { get; set; }
        public Client(User user)
        {
            Login = user.Login;
            Password = user.Password;
            FirstName = user.FirstName;
            LastName = user.LastName;
            PhoneNumber = user.PhoneNumber;
            EmailAddress = user.EmailAddress;
            User_id = user.User_id;
            Permission = user.Permission;
        }
    }
}
