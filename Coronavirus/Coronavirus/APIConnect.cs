using System;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;

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
            List<CovidData> states = new List<CovidData>();
            string url = "https://api.covidactnow.org/v2/states.json?apiKey=ed4c4cc29da845f895fa2f54e3ed47bb";
            dynamic jo = Connect(url);

            foreach (var c in GetCovid)
            {

            }

            //foreach(JObject item in JArray)
            //{
                //string name = item.GetValue("cases").ToString();
            //}
            //return states;
            
            //foreach ( int in jo)
            //{
                //Console.WriteLine();
            //}
            //return states;
            //if(jo[8]= "metrics")
            //{
               // Debug.WriteLine(jo[8]["testPositivityRatio"]);
            //}

           // return states;
            //if (jo[8] = (int)jo["metrics"]["testPositivityRatio"]) 
            //{
              //  Console.WriteLine(states);
            //}
            //return states;


            //foreach (dynamic a in jo.state[0]) 
            //{
                
              // Console.WriteLine(jo.state);
            //}
            //return states;
        }
    }
}
