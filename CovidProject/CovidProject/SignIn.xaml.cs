using System;
using System.Collections.Generic;
using CovidProject.Models;
using Xamarin.Forms;

namespace CovidProject
{
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            InitializeComponent();

            signinButton.Clicked += SigninButton_Clicked;
        }

        private void SigninButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NCData
            {

            });
        }
    }
}
