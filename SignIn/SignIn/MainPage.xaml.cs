using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SignIn.Models;
using System.IO;
using System.Collections.ObjectModel;


namespace SignIn
{
    public partial class MainPage : ContentPage
    {

        private string fileNameforSaving = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Signin.txt");
       

        public MainPage()
        {
            InitializeComponent();

          
            signupButton.Clicked += SignupButton_Clicked;
            signinButton.Clicked += SigninButton_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        private void SigninButton_Clicked(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter(fileNameforSaving))
            {
                writer.WriteLine(fnameEntry.Text);
                writer.WriteLine(lnameEntry.Text);
                writer.WriteLine(usernameEntry.Text);
                writer.WriteLine(passwordEntry.Text);
                writer.WriteLine(emailEntry.Text);

            }
            Navigation.PushAsync(new SignInPage
            {
                BindingContext = new UserData()
            });

        }

        async void SignupButton_Clicked(object sender, EventArgs e)
        {

       
            if(File.Exists(usernameEntry.Text))
            {
                await DisplayAlert("Username Taken.", "This username is taken.Please choose another one", "Ok");
            }

            if (string.IsNullOrWhiteSpace(fnameEntry.Text) || string.IsNullOrWhiteSpace(lnameEntry.Text) || string.IsNullOrWhiteSpace(usernameEntry.Text) || string.IsNullOrWhiteSpace(emailEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                await DisplayAlert("Empty Field/s", "Please complete all fields", "Ok");
                
            }
            
            else if (File.Exists(fileNameforSaving))
            {
                usernameEntry.Text = File.ReadAllText(fileNameforSaving);
                
                

            }

            
            
                
            else if (File.Exists(fileNameforSaving))
            {
                emailEntry.Text = File.ReadAllText(fileNameforSaving);

                await DisplayAlert("Email Taken.", "This email is taken.Please choose another one", "Ok");
            }
                
            
            else
            {
                await DisplayAlert("", "Thank you for signing up", "Ok");
            }
            
        }
    }
}