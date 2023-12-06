using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfTheNewRepublic.GameLogic.Character
{
    internal interface ICanAttack
    {
        bool attemptAttack(int difficulty);
    }
}
