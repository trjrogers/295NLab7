using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class OnlineMediaModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public OnlineMediaModel(string title, string description, string link)
        {
            Title = title;
            Description = description;
            Link = link;
        }
    }
}
