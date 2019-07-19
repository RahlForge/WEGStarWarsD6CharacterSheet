using System.Collections.Generic;

namespace WEGSWD6CSLib {
    public class StarWarsAttribute: StarWarsD6Score {
        public StarWarsAttribute(string name): base(name) {}
    }

    public class StarWarsAttributes {
        public enum AttributeKeys { Dexterity=1, Knowledge, Mechanical, Perception, Strength, Technical }
        
        public Dictionary<AttributeKeys, string> AttributeNames =
            new Dictionary<AttributeKeys, string> { 
                { AttributeKeys.Dexterity, "Dexterity" },
                { AttributeKeys.Knowledge, "Knowledge" },
                { AttributeKeys.Mechanical, "Mechanical" },
                { AttributeKeys.Perception, "Perception" },
                { AttributeKeys.Strength, "Strength" },
                { AttributeKeys.Technical, "Technical" }
            };        

        private List<StarWarsAttribute> attributes;
        public List<StarWarsAttribute> Attributes { get { return attributes; } }

        public StarWarsAttributes() {
            foreach (var a in AttributeNames)
                attributes.Add(new StarWarsAttribute(a.Value));
        }
    }
}