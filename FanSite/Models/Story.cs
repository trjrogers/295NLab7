using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FanSite.Models
{
    public class Story
    {
        private List<Comment> comments = new List<Comment>();

        public List<Comment> Comments { get { return comments; } }

        public User User { get; set; }

        [Required(ErrorMessage = "Please enter your story's title")]
        public string StoryTitle { get; set; }

        [Required(ErrorMessage = "Please enter your story")]
        public string StoryText { get; set; }

        public void AddComment(Comment c)
        {
            comments.Add(c);
        }
    }
}
