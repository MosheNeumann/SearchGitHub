using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstAPI.Data;

namespace MyFirstAPI.web.Models
{
    public class ViewModel
    {
        public Person person { get; set; }
        public List<Project> Projects { get; set; }
    }
}