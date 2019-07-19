using System.Collections.Generic;

namespace WEGSWD6CSLib {
    public class StarWarsSkill : StarWarsD6Score {
        public StarWarsSkill(string name): base(name) {}
    }

    public class StarWarsSkills {

        public enum SkillKeys {
            ArchaicGuns, Blaster, BlasterArtillery, Bowcaster, BrawlingParry,
            Dodge, Grenade, Lightsaber, MeleeCombat, MeleeParry, MissileWeapons,
            PickPocket, Running, ThrownWeapons, VehicleBlasters, AlienSpecies,
            Bureaucracy, Business, Cultures, Intimidation, Languages, LawEnforcement,
            PlanetarySystems, Scholar, Streetwise, Survival
        }

        public Dictionary<SkillKeys, string> SkillNames =
            new Dictionary<SkillKeys, string> {

            };
        
        public StarWarsSkills() {

        }
    }
}