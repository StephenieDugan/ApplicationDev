﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_of_the_Neu_Republic.Utilities
{
    internal class StormTrooper: Character, ICanAttack
    {
        public int damage { get; set; }
        public bool attemptAttack(int damage)
        {
            return false;
        }
}
}
