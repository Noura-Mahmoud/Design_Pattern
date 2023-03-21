namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            GroundBuilder B1 = new RainyGround();
            GroundBuilder B2 = new SunnyGround();

            director.Construct(B1);
            Ground G1 = B1.BuildGround();
            G1.Show();

            director.Construct(B2);
            Ground G2 = B2.BuildGround();
            G2.Show();
        }
    }
}