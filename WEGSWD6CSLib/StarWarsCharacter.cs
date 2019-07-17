using System;

namespace WEGSWD6CSLib
{
    public class StarWarsCharacter
    {
        public string CharacterName { get; set; }

        public string Type { get; set; }

        public string Gender { get; set; }

        public StarWarsSpecies Species { get; set; }
        
        private int age;
        public int Age { 
            get { return age; } 
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Age cannot be less than 0");
                else
                    age = value;
            }
        }

        public decimal Height { get; set; }

        public StarWarsCharacter() {}
    }
}
