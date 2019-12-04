using Xunit;
using FanSite.Controllers;
using FanSite.Repositories;
using FanSite.Models;
using System.Collections.Generic;

namespace StoryTests
{
    public class StoryTests
    {
        [Fact]
        public void InitializationTest()
        {
            // First test I ran
            //Assert.Equal(2, (2 + 2));

            var repo = new FakeStoryRepository();
            var homeController = new HomeController(repo);

            User u = new User();
            u.Username = "Trevor";
            u.Email = "rogerst@my.lanecc.edu";

            Story s = new Story();
            s.StoryTitle = "Example";
            s.StoryText = "Example text";
            s.User = u;

            homeController.StoryForm(s);

            Assert.NotEmpty(repo.StoriesList);
        }

        [Fact]
        public void StorySortTest()
        {
            var repo = new FakeStoryRepository();
            var homeController = new HomeController(repo);

            User u1 = new User();
            u1.Username = "Trevor";
            u1.Email = "rogerst@my.lanecc.edu";
            Story s1 = new Story();
            s1.StoryTitle = "Example";
            s1.StoryText = "Example text";
            s1.User = u1;

            User u2 = new User();
            u2.Username = "Tera";
            u2.Email = "example@test.com";
            Story s2 = new Story();
            s2.StoryTitle = "Another example";
            s2.StoryText = "More example text";

            homeController.StoryForm(s1);
            homeController.StoryForm(s2);

            List<Story> stories = homeController.SortStories(repo.StoriesList);

            Assert.Equal(s2, repo.StoriesList[0]);
        }

        // Comment sort test
        [Fact]
        public void SortCommentsTest()
        {
            var repo = new FakeStoryRepository();
            var homeController = new HomeController(repo);

            User u = new User();
            u.Username = "Trevor";
            u.Email = "rogerst@my.lanecc.edu";

            Story s = new Story();
            s.StoryTitle = "Example";
            s.StoryText = "Example text";
            s.User = u;

            homeController.StoryForm(s);

            Assert.Empty(repo.StoriesList[0].Comments);

            Story repoStory = repo.GetStoryByTitle(s.StoryTitle);
            homeController.CommentForm(repoStory.StoryTitle, "Jim", "lol@mail.com", "This is a comment");
            homeController.CommentForm(repoStory.StoryTitle, "James", "test@test.com", "Another comment");
            homeController.SortComments(repoStory.Comments);
            Comment c = repoStory.Comments[0];
            //List<Comment> comments = repo.StoriesList[0].Comments;
            //Comment c = comments[0];
            Assert.Equal("Another comment", c.CommentText);
        }
    }
}
