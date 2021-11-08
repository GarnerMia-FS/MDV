using System;
using System.Collections.Generic;

namespace SignIn.Models
{
    public class UserData
    {

        public string FName { get; set; }
        public string LName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
        public string Text { get; set; }
        public string Filename { get; set; }



        public UserData()
        {
        }

        public class AllUserData
        {
            public static List<UserData> Get()
            {
                return new List<UserData>
                {
                    new UserData() {FName="Mia", LName="Lane", Username="ML",Email="ml@email.com",Password="password",Password2="password"},
                    new UserData() {FName="Bob", LName="Lane", Username="BL",Email="bl@email.com",Password="password1",Password2="password1"},
                    new UserData() {FName="Sam", LName="Lane", Username="SL",Email="sl@email.com",Password="password2",Password2="password2"},
                    new UserData() {FName="Lee", LName="Lane", Username="LL",Email="ll@email.com",Password="password3",Password2="password3"},



                };
            }
        }
    }
}
