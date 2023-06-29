using GenshinQuake.BodyShape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinQuake
{
    interface IPlayable
    {
    }

    public class PlayableCharacter : Character, IPlayable, IBodyShape, ICombative, IMouth
    {
        public static bool IsPlayable => true;

        public BodyShape.BodyShape BodyShape { get; private set; }

        public int Attack { get; private set; }

        public PlayableCharacter(int hp, int atk, BodyShape.BodyShape bs) : base(hp)
        {
            BodyShape = bs;
            Attack = atk;
        }

        public void Attacking(IAlive attackable)
        {
            attackable.Attacked(this);
        }

        public void Say(PlicaVocalis p)
        {
            p.Invoke($"name {GetType().Name}  HP:{HealthPoints}  Atk:{Attack}");
        }
    }
}
