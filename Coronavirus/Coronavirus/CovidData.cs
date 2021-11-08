using System;
namespace Coronavirus
{
    public class CovidData
    {
        public int Cases { get; set; }
        public int Deaths { get; set; }
        public int Icubeds { get; set; }
        public int VaccinesInitiated { get; set; }



        public CovidData(int cases, int deaths, int icu, int vaccines)
        {
            Cases = cases;
            Deaths = deaths;
            Icubeds = icu;
            VaccinesInitiated = vaccines;
        }
    }
}
