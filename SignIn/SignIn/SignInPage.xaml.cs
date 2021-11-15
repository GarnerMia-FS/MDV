using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.IO;
using SignIn.Models;

namespace SignIn
{
    public partial class SignInPage : ContentPage
    {
        private string fileNameforSaving = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Signin.txt");

        public SignInPage()
        {
            InitializeComponent();
            signinButton.Clicked += SigninButton_Clicked;
            signupButton.Clicked += SignupButton_Clicked;
            forgotUP.Clicked += ForgotUP_Clicked;

        }

        async void ForgotUP_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Hint", "Password", "OK");
        }

        private void SignupButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage
            {
                
            });


        }

       async void SigninButton_Clicked(object sender, EventArgs e)
        {
            var user = (UserData)BindingContext;
            string line = "";
            using(StreamReader sr = new StreamReader(fileNameforSaving))
            {
                while((line = sr.ReadLine()) != null)
                {
                    user.Username = usernameEntry.Text;

                    user.Email = emailEntry.Text;
                }

                
            }

           

            if (File.Exists(user.Filename))
            {
                await DisplayAlert("Hint", "You are signed in", "OK");
            }
            else
            {
                await DisplayAlert("Hint", "User does not exist, would you like to sign up", "Try Again","Sign Up");
            }
            await Navigation.PushAsync(new NCData
            {

            });

        }
    }
}
