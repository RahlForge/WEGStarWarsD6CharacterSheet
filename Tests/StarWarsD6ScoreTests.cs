using System;
using System.Collections.Generic;
using Xunit;
using WEGSWD6CSLib;

namespace WEGSWD6CSLib.Tests
{
    public class StarWarsD6ScoreTests
    {
        public static IEnumerable<object[]> PropertyNegatives {
            get {
                yield return new object[] {-1};
                yield return new object[] {-10};
                yield return new object[] {-100};
                yield return new object[] {-1000};
            }
        }   

        [Fact]
        public void HasNameProperty()
        {
            var name = "Score Name";
            StarWarsD6Score sw = new StarWarsD6Score(name);
            Assert.True(sw.Name == name);
        }     

        [Fact]
        public void HasNumberOfDice()
        {
            StarWarsD6Score sw = new StarWarsD6Score("Score");
            Assert.True(sw.Dice == 1);
        }           

        [Fact]
        public void CanUpdateDice()
        {
            StarWarsD6Score sw = new StarWarsD6Score("Score");
            sw.Dice = 3;
            Assert.True(sw.Dice == 3);
        }

        [Fact]
        public void HasBonus()
        {
            StarWarsD6Score sw = new StarWarsD6Score("Score");
            Assert.True(sw.Bonus == 0);
        }

        [Fact]
        public void CanUpdateBonus()
        {
            StarWarsD6Score sw = new StarWarsD6Score("Score");
            sw.Bonus = 2;
            Assert.True(sw.Bonus == 2);
        }

        [Fact]
        public void BonusCanUpdateDice()
        {
            StarWarsD6Score sw = new StarWarsD6Score("Score");
            sw.Bonus = 4;
            Assert.True(sw.Dice == 2);
            Assert.True(sw.Bonus == 0);
        }

        [Theory]
        [MemberData(nameof(PropertyNegatives))]
        public void DoesNotAllowNegativeBonus(int negative)
        {
            StarWarsD6Score sw = new StarWarsD6Score("Score");
            Assert.Throws<ArgumentOutOfRangeException>(() => sw.Bonus = negative);
        }
    }
}