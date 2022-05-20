using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    public class SerratedDirk : Item
    {
        public SerratedDirk()
        {
            name = "Serrated Dirk";
            
            price = 1100;

            AddStat(Stat.AD, 30);
            AddStat(Stat.Lethality, 10);
        }
    }
}
