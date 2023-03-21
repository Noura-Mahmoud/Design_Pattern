namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team t1= new Team();
            t1.SetStrategy(new AttackStrategy());
            t1.PlayGame();
            t1.SetStrategy(new DefendStrategy());
            t1.PlayGame();
        }
    }
}