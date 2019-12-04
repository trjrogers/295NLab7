using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FanSite.Models
{
    public class Comment
    {
        public int Id { get; set; }

        //Added these in the effort to provide the commented-on-story's title to the view, which is happening, 
        //but when I pass the title back to the controller, the title is 'null'
        //public string storyTitle;
        //public string username;
        //public string email;

        [Required(ErrorMessage = "Please enter your username")]
        public User User{ get; set; }

        [Required(ErrorMessage = "Please leave your comment")]
        public string CommentText { get; set; }

        // Also added this in the aformentioned effort on line 11
        //public string StoryTitle { get { return storyTitle; } set { storyTitle = value; } }
    }
}
