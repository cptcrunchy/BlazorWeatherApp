using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BlazorWeatherApp.Models
{
    public class ZipLookup
    {
        public Place[] Places { get; set; }
    }
    public class Place
    {
        public string City { get; set; }
        public string Stateabbr { get; set; }
    }
}
