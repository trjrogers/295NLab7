using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FanSiteTests
{
    public class StoryTests
    {
        [Fact]
        public void StoryTest()
        {
            var repo = new FakeStoryRepository();
        }
    }
}
