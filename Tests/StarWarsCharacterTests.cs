using System;
using Xunit;
using WEGSWD6CSLib;

namespace WEGSWD6CSLib.Tests
{
    public class StarWarsCharacterTests    
    {
        StarWarsCharacter sw = new StarWarsCharacter();

        [Fact]
        public void HasEditableCharacterName()
        {
            sw.CharacterName = "Han Solo";
            Assert.True(sw.CharacterName != "");
        }

        [Fact]
        public void HasEditableType()
        {
            var swType = "Cocky Smuggler";
            sw.Type = swType;
            Assert.True(sw.Type == swType);
        }

        [Fact]
        public void HasEditableGender()
        {
            var gender = "Some Gender Other Than Male or Female";
            sw.Gender = gender;
            Assert.True(sw.Gender == gender);
        }

        [Theory]
        [InlineData(StarWarsSpecies.Human)]
        [InlineData(StarWarsSpecies.Wookie)]
        [InlineData(StarWarsSpecies.MonCalamari)]
        [InlineData(StarWarsSpecies.Sullustan)]
        [InlineData(StarWarsSpecies.Rodian)]
        public void HasSelectableSpecies(StarWarsSpecies species)
        {
            sw.Species = species;
            Assert.True(sw.Species == species);
        }

        [Fact]
        public void HasEditableNumericAge()
        {
            var age = 16;
            sw.Age = age;
            Assert.True(sw.Age == age);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        public void DoesNotAllowNegativeAges(int negative)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => sw.Age = negative);
        }

        [Fact]       
        public void HasEditableDecimalHeight()
        {
            var height = 1.2m;
            sw.Height = height;
            Assert.True(sw.Height == height);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        public void DoesNotAllowNegativeHeight(int negative)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => sw.Height = negative);
        }
    }
}
