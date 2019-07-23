using System;

namespace WEGSWD6CSLib
{
    public interface IStarWarsD6Score {
        
    }

    public class StarWarsD6Score
    {
        private string name;
        public string Name { get { return name; } }

        public int Dice { get; set; } = 1;

        private int bonus = 0;
        public int Bonus { 
            get {
                return bonus;
            } 
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Bonus cannot be negative");
                else if (value > 3) {
                    Dice += 1;
                    bonus = 0;
                } else {
                    bonus = value;
                }
            } 
        }

        public StarWarsD6Score(string name) {
            this.name = name;
        }
    }
}