using System.Collections.Generic;

namespace FanSite.Models
{
    public static class Repository
    {
        public static List<Story> stories = new List<Story>();
        public static List<OnlineMediaModel> online = new List<OnlineMediaModel>();
        public static List<PhysicalMediaModel> physical = new List<PhysicalMediaModel>();

        public static IEnumerable<PhysicalMediaModel> Physical
        {
            get
            { return physical;  }
        }

        public static IEnumerable<OnlineMediaModel> Online
        {
            get { return online; }
        }

        public static IEnumerable<Story> Stories
        {
            get
            {
                return stories;
            }
        }

        public static void AddStory(Story story)
        {
            stories.Add(story);
        }

        public static Story GetStoryByTitle(string storyTitle)
        {
            return Repository.stories.Find(x => x.StoryTitle == storyTitle);
        }

        public static void AddOnline(OnlineMediaModel o)
        {
            online.Add(o);
        }

        public static void AddPhysical(PhysicalMediaModel p)
        {
            physical.Add(p);
        }
    }
}
