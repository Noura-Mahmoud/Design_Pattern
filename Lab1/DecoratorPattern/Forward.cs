using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Forward:PlayerRole
    {
        public void ShootGoal()
        {
            Console.WriteLine("Shoot goal");
        }
    }
}
