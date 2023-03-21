using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Observer
    {
        public virtual void Update()
        {
            Console.WriteLine("this is observer base class");
        }
    }
    public class Player: Observer
    {
        Position ballPosition;
        Position BallPosition { get; set; }
        public override void Update()
        {
            Console.WriteLine("Player updating");
        }
    }
    public class Refree : Observer
    {
        Position ballPosition;
        Position BallPosition { get; set; }
        public override void Update()
        {
            Console.WriteLine("Refree updating");
        }
    }
}
