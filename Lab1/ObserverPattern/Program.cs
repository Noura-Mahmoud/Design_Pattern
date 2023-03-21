namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Refree r = new Refree();
            FootBall ball = new FootBall();
            ball.AttachObserver(p1);
            ball.AttachObserver(p2);
            ball.AttachObserver(r);
            ball.SetBallPosition( new Position(3, 4, 5));
        }
    }
}