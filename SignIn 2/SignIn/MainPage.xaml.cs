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
        private List<UserData> userList = new List<UserData>();

        public MainPage()
        {
            InitializeComponent();

            
            signupButton.Clicked += SignupButton_Clicked;
            signinButton.Clicked += SigninButton_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var files = Directory.EnumerateFiles(App.FolderPath, "*.SignIn.txt");
            foreach (var filename in files)
            {
                userList.Add(new UserData
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename)
                });
                
                
            }
        }

        private void SigninButton_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new SignInPage
            {
                BindingContext = new UserData()
            });

        }

        async void SignupButton_Clicked(object sender, EventArgs e)
        {
           
            

            if (string.IsNullOrWhiteSpace(fnameEntry.Text) || string.IsNullOrWhiteSpace(lnameEntry.Text) || string.IsNullOrWhiteSpace(usernameEntry.Text) || string.IsNullOrWhiteSpace(emailEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                await DisplayAlert("Empty Field/s", "Please complete all fields", "Ok");

            }
            else if (emailEntry.Text == fileNameforSaving)
            {
                await DisplayAlert("", "This email is taken. Please choose another one.", "Ok");
            }
            else if (usernameEntry.Text == fileNameforSaving)
            {
                await DisplayAlert("", "This username is taken. Please choose another one", "Ok");
            }
           
            else if(fnameEntry.Text != fileNameforSaving && lnameEntry.Text == fileNameforSaving && usernameEntry.Text == fileNameforSaving && passwordEntry.Text == fileNameforSaving && passoword2Entry.Text == fileNameforSaving && emailEntry.Text == fileNameforSaving)
            {
                await DisplayAlert("", "Thank you for signing up", "Ok");
            }
        }
    }
}