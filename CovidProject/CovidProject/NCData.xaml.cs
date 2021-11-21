using System;
using System.Collections.Generic;
using CovidProject.Models;

using Xamarin.Forms;

namespace CovidProject
{
    public partial class NCData : ContentPage
    {
        public NCData()
        {
            InitializeComponent();
            covidButton.Clicked += CovidButton_Clicked;
        }

        async void CovidButton_Clicked(object sender, EventArgs e)
        {
            DataManager dm = new DataManager();
             CovidData newcovidData = await dm.GetStat();

            casesLabel.Text = "Cases" + newcovidData.Cases;
            deathsLabel.Text = "Deaths" + newcovidData.Deaths;
            vaccinationsLabel.Text = "Vaccinations Completed" + newcovidData.VaccinationsCompleted;
        }
    }
}
