using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPI.Data
{
public    class Repository
    {
       public Person GetPerson(string PersonURL)
        {
            using (var client = new WebClient())
            {
                client.Headers["User-Agent"] = "anything...";
                string result = client.DownloadString(PersonURL);
                Person person = JsonConvert.DeserializeObject<Person>(result);

                return person;
            }
        }
        public List<Project>AllProjects(string ProjectsURL)
        {
            using (var client = new WebClient())
            {
                client.Headers["User-Agent"] = "anything...";
                string result = client.DownloadString(ProjectsURL);
                 List < Project > projects = JsonConvert.DeserializeObject<List<Project>>(result);

                return projects;
            }
        }
    }
}
