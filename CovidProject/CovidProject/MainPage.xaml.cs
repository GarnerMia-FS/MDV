using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CovidProject
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage ncdata = new NavigationPage(new NCData());
            ncdata.IconImageSource = "bar.png";
            ncdata.Title = "Data";


            NavigationPage searchdata = new NavigationPage(new SearchView());
            searchdata.IconImageSource = "search.png";
            searchdata.Title = "Search";



            NavigationPage newsdata = new NavigationPage(new NewsView());
            newsdata.IconImageSource = "news.png";
            newsdata.Title = "News";

            NavigationPage testingdata = new NavigationPage(new TestingView());
            testingdata.IconImageSource = "swab.png";
            testingdata.Title = "Testing";



            Children.Add(ncdata);
            Children.Add(searchdata);
            Children.Add(newsdata);
            Children.Add(testingdata);
        }
    }
}
