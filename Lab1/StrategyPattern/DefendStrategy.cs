using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DefendStrategy:TeamStrategy
    {
        public override void Play()
        {
            Console.WriteLine("Defend strategy");
        }
    }
}
