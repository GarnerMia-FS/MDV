using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Coronavirus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            covidButton.Clicked += CovidButton_Clicked;

        }

        private void CovidButton_Clicked(object sender, EventArgs e)
        {
            DataManager dataManager = new DataManager();
            

        }
    }
}
