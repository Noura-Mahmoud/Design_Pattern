namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new field player and assign it as forward
            Player player = new FieldPlayer();
            PlayerRole forward = new Forward();
            forward.AssignPlayer(player);

            // Try passing the ball and shooting the goal
            forward.PassBall();
            ((Forward)forward).ShootGoal();

            // Create a new goalkeeper and assign it as midfielder
            player = new GoalKeeper();
            PlayerRole midfielder = new MidFielder(); 
            midfielder.AssignPlayer(player);
            midfielder.PassBall();
            ((MidFielder)midfielder).Dribble();

            // Create a new field player and assign it as defender
            player = new FieldPlayer();
            PlayerRole defender = new Defender();
            defender.AssignPlayer(player);

            defender.PassBall();
            ((Defender)defender).Defend();
        }
    }
}