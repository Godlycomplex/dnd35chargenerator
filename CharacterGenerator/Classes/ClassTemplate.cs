namespace CharacterGenerator.Classes
{
    public interface IClassTemplate
    {

    }

    public abstract class ClassTemplate : IClassTemplate
    {
        public int[][] baseAttackBonus { get; set; }
        public int[] reflexSave { get; set; }
        public int[] fortificationSave { get; set; }
        public int[] willSave { get; set; }
        public int hitDice { get; set; }
        public int skillPoints { get; set; }
        public bool[] abilityStatPoint { get; set; }
        public int[] feats { get; set; }
        public int[][] spellsPerDay { get; set; }
    }
}
	