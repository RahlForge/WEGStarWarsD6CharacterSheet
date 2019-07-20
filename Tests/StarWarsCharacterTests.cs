using System;
using System.Collections.Generic;
using Xunit;
using WEGSWD6CSLib;

namespace WEGSWD6CSLib.Tests
{
    public class StarWarsCharacterTests    
    {
        StarWarsCharacter sw = new StarWarsCharacter();      

        public static IEnumerable<object[]> PropertyNegatives {
            get {
                yield return new object[] {-1};
                yield return new object[] {-10};
                yield return new object[] {-100};
                yield return new object[] {-1000};
            }
        }           

        [Fact]
        public void HasEditableCharacterName()
        {
            sw.CharacterName = "Luke Skywalker"; 
            sw.CharacterName = "Han Solo";
            Assert.True(sw.CharacterName == "Han Solo");
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
        [MemberData(nameof(PropertyNegatives))]
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
        [MemberData(nameof(PropertyNegatives))]
        public void DoesNotAllowNegativeHeight(int negative)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => sw.Height = negative);
        }

        [Fact]
        public void HasEditableDecimalWeight()
        {
            var weight = 54.5m;
            sw.Weight = weight;
            Assert.True(sw.Weight == weight);
        }

        [Theory]
        [MemberData(nameof(PropertyNegatives))]
        public void DoesNotAllowNegativeWeight(int negative)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => sw.Weight = negative);
        }

        [Fact]
        public void HasEditableDescription()
        {
            var description = "Brash Smuggler";
            sw.Description = description;
            Assert.True(sw.Description == description);
        }
    }
}
