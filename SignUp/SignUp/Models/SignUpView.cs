using System;
using System.IO;

namespace SignUp.Models
{
    public class SignUpView
    {

        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get
            {
                return FirstName + "" + LastName;
            }
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Filename { get; set; }
        
        public SignUpView()
        {
            
        }
    }
}
