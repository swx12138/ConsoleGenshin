using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinQuake
{
    public delegate void PlicaVocalis(string s);

    public interface IMouth
    {
        public void Say(PlicaVocalis p);
    }
}
