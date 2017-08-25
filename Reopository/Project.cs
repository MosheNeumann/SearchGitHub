using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPI.Data
{
 public   class Project
    {
         public string Name { get; set; }
        [JsonProperty("stargazers_count")]
        public int Stars { get; set; }

        [JsonProperty("watchers_count")]
        public int Watchers { get; set; }
        public string language { get; set; }

        public string Description { get; set; }
    }
}
