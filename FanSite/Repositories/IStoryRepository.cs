using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FanSite.Models;

namespace FanSite.Repositories
{
    public interface IStoryRepository
    {
        IQueryable<Story> Stories { get; }
        void AddStory(Story story);
        //void AddComment(Story story, Comment comment);
        Story GetStoryByTitle(string storyTitle);
    }
}
