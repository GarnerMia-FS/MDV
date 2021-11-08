using System;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Collections.Generic;

namespace Coronavirus
{
    public class APIConnect
    {
        public APIConnect()
        {
        }
        public dynamic Connect(string url)
        {
            
                dynamic jo;
                using(WebClient wc = new WebClient())
                {
                    string results = wc.DownloadString(url);
                    jo = JArray.Parse(results);
                }
                
                
            
            return jo;
        }
        public List<CovidData> GetCovid()
        {
            List<CovidData> annotations = new List<CovidData>();
            string url = ("https://api.covidactnow.org/v2/states.json?apiKey=ed4c4cc29da845f895fa2f54e3ed47bb");
            dynamic jo = Connect(url);
           

            return annotations;
        }
    }
}
