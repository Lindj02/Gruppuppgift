using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppuppgift
{
    public class User
    {
        private const string AdminUsername = "admin";
        private const string AdminPassword = "psw12345";

        public bool IsAdmin { get; private set; }

        
        public User()
        {
            IsAdmin = false;
        }
        public void Logout()
        {
            IsAdmin = false;
        }

        
        public User(string inputUsername, string inputPassword)
        {
            IsAdmin = Authenticate(inputUsername, inputPassword);
        }

        public bool Authenticate(string inputUsername, string inputPassword)
        {
            return inputUsername == AdminUsername && inputPassword == AdminPassword;
        }
    }
}
