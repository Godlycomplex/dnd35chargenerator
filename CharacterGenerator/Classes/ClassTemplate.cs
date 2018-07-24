namespace CharacterGenerator.Classes
{
    class ClassTemplate
    {
        int[] BaseAttackBonus { get; set; }
        int[] ReflexSave { get; set; }
        int[] FortificationSave { get; set; }
        int[] WillSave { get; set; }
        int HitDice { get; set; }
        int SkillPoints { get; set; }
        bool[] AbilityStatPoint { get; set; }
        int[] Feats { get; set; }
    }
}
