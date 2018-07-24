namespace CharacterGenerator.Classes
{
    public interface IClassTemplate
    {

    }

    public abstract class ClassTemplate : IClassTemplate
    {
        public int[][] baseAttackBonus { get; set; }
        public int[] reflexSave { get; }
        public int[] fortificationSave { get; }
        public int[] willSave { get; }
        public int hitDice { get; }
        public int skillPoints { get; }
        public bool[] abilityStatPoint { get; }
        public int[] feats { get; }
    }
}
