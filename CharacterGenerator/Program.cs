using System;
using System.Collections.Generic;

namespace CharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var fighter = new CharacterClasses();
            var cleric = new CharacterClasses();
            var rogue = new CharacterClasses();
        }
    }
    class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int BaseAttack { get; set; }
        public int ArmorClass { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constition { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }

    class CharacterLevelups
    {

    }

    public class CharacterClasses
    {

        List<CharacterLevelups> Levels;

    }
}
