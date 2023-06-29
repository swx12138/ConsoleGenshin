using GenshinQuake.BodyShape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinQuake.Characters
{
    public class Amber : PlayableCharacter
    {
        public Amber(int hp, int atk) : base(hp, atk, GenshinQuake.BodyShape.BodyShape.Girl) { }

        public string Saysmt()
        {
            return $"{GetType().Name} - IsPlayable:{IsPlayable} - BodyShape:{BodyShape}";
        }
    }
}
