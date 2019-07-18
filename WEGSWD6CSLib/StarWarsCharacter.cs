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

        private decimal height;
        public decimal Height { 
            get { return height; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Height cannot be less than 0");
                else
                    height = value;
            }
        }

        private decimal weight;
        public decimal Weight {
            get { return weight; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Weight cannot be less than 0");
                else
                    weight = value;
            }
        }

        public StarWarsCharacter() {}
    }
}
