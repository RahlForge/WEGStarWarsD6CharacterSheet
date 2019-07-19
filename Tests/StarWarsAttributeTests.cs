using Xunit;
using WEGSWD6CSLib;

namespace WEGSWD6CSLib.Tests
{
    public class StarWarsAttributeTests
    {
        [Fact]
        public void IsD6ScoreType()
        {
            StarWarsAttribute swa = new StarWarsAttribute("Name");
            Assert.IsAssignableFrom(typeof(StarWarsD6Score), swa);
        }
    }
}