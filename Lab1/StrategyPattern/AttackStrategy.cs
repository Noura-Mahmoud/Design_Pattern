using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class AttackStrategy:TeamStrategy
    {
        public override void Play()
        {
            Console.WriteLine("Attack strategy");
        }
    }
}
