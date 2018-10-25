using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWeatherApp.Models
{
    public class Alert
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public Feature[] Features { get; set; }
    }

    public class Feature
    {
        public string Type { get; set; }
        public PropertyInfo Properties { get; set; }
    }

    public class PropertyInfo
    {
        public string Headline { get; set; }
        public string Description { get; set; }
        public DateTime Effective { get; set; }
        public DateTime Expires { get; set; }

    }
}
