using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demoMvc.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public bool IsOnTheBillboard { get; set; }
        public string Gender { get; set; }
    }
}