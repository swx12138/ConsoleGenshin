using GenshinQuake.BodyShape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinQuake.Characters
{
    public class Eula : PlayableCharacter
    {
        public Eula(int hp, int atk) : base(hp, atk, GenshinQuake.BodyShape.BodyShape.Lady) { }

        public string Saysmt()
        {
            return $"{GetType().Name} - IsPlayable:{IsPlayable} - BodyShape:{BodyShape}";
        }
    }
}
