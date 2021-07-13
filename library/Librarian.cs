using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace library
{
    public class Librarian : User
    {
        public Librarian(User user)
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
