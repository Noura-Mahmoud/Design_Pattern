using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FieldPlayer: Player
    {
        public void PassBall()
        {
            Console.WriteLine("Field player");
        }
    }
}
