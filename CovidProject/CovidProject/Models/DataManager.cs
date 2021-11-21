using System;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CovidProject.Models
{
    public class DataManager
    {
        JArray myData;
        WebClient apiConnections = new WebClient();

        string startAPI = "https://api.covidactnow.org/v2/states.json?apiKey=ed4c4cc29da845f895fa2f54e3ed47bb";

        

        public DataManager()
        {
        }

        public async Task<CovidData> GetStat()
        {
            //Download Data
            string results = await apiConnections.DownloadStringTaskAsync(startAPI);
            myData = JArray.Parse(results);

            JObject firstStat = (JObject)myData["actuals"];

            //Loop through the data
            foreach(JObject state in myData)
            {
                if ((string) state["state"] == "NC")
                {
                    Debug.WriteLine(state["state"]["actuals"][0]["cases"]);
                }
            }

            CovidData covidData = new CovidData();
            covidData.Cases = int.Parse(firstStat["cases"].ToString());
            covidData.Deaths = int.Parse(firstStat["deaths"].ToString());
            covidData.VaccinationsCompleted = int.Parse(firstStat["vaccinationsCompleted"].ToString());

            return covidData;
        }
    }
}
