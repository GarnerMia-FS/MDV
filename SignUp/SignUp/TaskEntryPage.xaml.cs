using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SignUp
{
    public partial class TaskEntryPage : ContentPage
    {
        public TaskEntryPage()
        {
            InitializeComponent();
            signUpButton.Clicked += SignUpButton_Clicked;
        }

        private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
