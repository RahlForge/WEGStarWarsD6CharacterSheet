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
        public void HasNumericAge()
        {
            Assert.IsType<int>(sw.Age);
        }

        //TODO: Test that Age can be set
        [Fact]
        public void CanEditAge()
        {
            var age = 20;
            sw.Age = age;            
            Assert.True(sw.Age == age);
        }

        //TODO: Test that Age can only be positive 
    }
}
