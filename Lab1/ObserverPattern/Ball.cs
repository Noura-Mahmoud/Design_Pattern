using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Ball
    {
        List<Observer> observers = new();
        public void AttachObserver(Observer observer)
        {
            observers.Add(observer);
        }
        public void DetachObserver(Observer observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
    public class FootBall: Ball
    {
        Position myPosition;
        public Position GetBallPosition()
        {
            return myPosition;
        }
        public void SetBallPosition(Position position)
        {
            myPosition = position;
            NotifyObservers();
        }
    }

}
