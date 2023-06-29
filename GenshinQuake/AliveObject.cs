using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinQuake
{
    public interface IAlive
    {
        public void Attacked(ICombative combator);
    }

    public class AliveObject : Object, IAlive
    {
        public int HealthPoints { get; private set; }

        public bool IsAlive => HealthPoints > 0;

        public AliveObject(int hp)
        {
            HealthPoints = hp;
        }

        public void Attacked(ICombative combator)
        {
            HealthPoints -= combator.Attack;
        }
    }
}
