using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public void Login()
        {
            // Code to log the user in
        }

        public void Logout()
        {
            // Code to log the user out
        }

        public void ChangePassword(string newPassword)
        {
            // Code to change the user's password
        }

        public void ResetPassword()
        {
            // Code to reset the user's password
        }
    }

}
