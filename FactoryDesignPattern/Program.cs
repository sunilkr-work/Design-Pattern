namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string type = "standard";

            var dominoFactory = new DominosPizzaFranchise();
            dominoFactory.CreateGarlicBread(type).PrepareGarlicBread();

            var pizzaHutFactory = new PizzaHuttFranchise();
            pizzaHutFactory.CreatePizza(type).PreparePizza();
            var a = 10;
        }
    }
}
