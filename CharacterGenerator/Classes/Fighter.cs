using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator.Classes
{
    public class Fighter : ClassTemplate
    {
        private void fighter()
        {
            this.baseAttackBonus = new int[][]
            {
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
                new int[] { 4 },
                new int[] { 5 },
                new int[] { 6, 1 },
                new int[] { 7, 2 },
                new int[] { 8, 3 },
                new int[] { 9, 4 },
                new int[] { 10, 5 },
                new int[] { 11, 6, 1 },
                new int[] { 12, 7, 2 },
                new int[] { 13, 8, 3 },
                new int[] { 14, 9, 4 },
                new int[] { 15, 10, 5 },
                new int[] { 16, 11, 6, 1 },
                new int[] { 17, 12, 7, 2 },
                new int[] { 18, 13, 8, 3 },
                new int[] { 19, 14, 9, 4 },
                new int[] { 20, 15, 10, 5 },
            };

            try
            {
                int firstAttack = baseAttackBonus[11][0];
                int secondAttack = baseAttackBonus[11][1];
                int thirdAttack = baseAttackBonus[11][2];
                if (baseAttackBonus[11][3] != null)
                {
                    int fourthAttack = baseAttackBonus[11][3];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
