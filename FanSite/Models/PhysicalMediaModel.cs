using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class PhysicalMediaModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public PhysicalMediaModel(string title, string description, string link)
        {
            Title = title;
            Description = description;
            Link = link;
        }
    }
}
