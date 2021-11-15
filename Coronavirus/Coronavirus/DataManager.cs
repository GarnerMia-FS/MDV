using System;
using System.Collections.Generic;

namespace Coronavirus
{
    public class DataManager
    {
        public DataManager()
        {
            APIConnect api = new APIConnect();

           

            List<CovidData> actuals = api.GetCovid();
        }

    }
}
