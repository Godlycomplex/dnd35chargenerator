﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator.Classes
{
    public class Cleric : ClassTemplate
    {
        private void cleric()
        {
            this.baseAttackBonus = new int[][]
            {
                new int[] { 0},
                new int[] { 1},
                new int[] { 2},
                new int[] { 3},
                new int[] { 3},
                new int[] { 4},
                new int[] { 5},
                new int[] { 6, 1 },
                new int[] { 6, 1 },
                new int[] { 7, 2 },
                new int[] { 8, 3 },
                new int[] { 9, 4 },
                new int[] { 9, 4 },
                new int[] { 10, 5 },
                new int[] { 11, 6, 1 },
                new int[] { 12, 7, 2 },
                new int[] { 12, 7, 2 },
                new int[] { 13, 8, 3 },
                new int[] { 14, 9, 4 },
                new int[] { 15, 10, 5 },
            };

            this.spellsPerDay = new int[][]
            {

            };
        }
    }
}
