using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Defender:PlayerRole
    {
        public void Defend()
        {
            Console.WriteLine("Defend");
        }
    }
}
