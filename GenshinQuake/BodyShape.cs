using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinQuake.BodyShape
{
    public enum BodyShape
    {
        Loli, Girl, Boy, Lady, Male
    }

    interface IBodyShape
    {
        public BodyShape BodyShape { get; }
    }
}
