using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppuppgift
{
        public class User
        {
            private const string Username = "admin";
            private const string Password = "psw12345";

            public bool Authenticate(string inputUsername, string inputPassword)
            {
                return inputUsername == Username && inputPassword == Password;
            }
        }
    
}
