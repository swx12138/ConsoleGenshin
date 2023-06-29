using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinQuake
{

    public interface ICombative
    {
        public int Attack { get; }

        public void Attacking(IAlive attackable);
    }
}
