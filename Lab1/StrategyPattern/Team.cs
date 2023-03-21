using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Team
    {
        TeamStrategy strategy;
        public void SetStrategy(TeamStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void PlayGame() 
        {
            strategy.Play();
        }
    }
}
