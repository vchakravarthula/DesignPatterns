namespace LLDPractice2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //var mallard = new MallardDuck();
            //mallard.PerformQuack();
            //mallard.PerformFly();

            //Duck model = new ModelDuck();
            //model.PerformFly();
            //model.PerformQuack();

            //model.SetFlyBehavior(new FlyRocketPowered());
            //model.PerformFly();

            Duck decoyDuck = new DecoyDuck();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
        }
    }
}
