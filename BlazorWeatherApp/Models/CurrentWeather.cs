using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorWeatherApp.Models
{
    public class CurrentConditions
    {
        public CurrentConditions() {}
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public string Name { get; set; }
    }

    public class Weather
    {
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Main
    {
        public decimal Temp { get; set; }
        public decimal Temp_min { get; set; }
        public decimal Temp_max { get; set; }
    }

}
