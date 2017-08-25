using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPI.Data
{
    public class Person
    {
        public string Company { get; set; }

        public string Location { get; set; }

        public string Name { get; set; }
        [JsonProperty("public_repos")]
        public int repos { get; set; }
    }

}
