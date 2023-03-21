using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class PlayerRole: Player
    {
        Player player;
        public void PassBall()
        {
            Console.WriteLine("player role class");
        }
        public void AssignPlayer(Player player)
        {
            this.player= player;
        }
    }
}
