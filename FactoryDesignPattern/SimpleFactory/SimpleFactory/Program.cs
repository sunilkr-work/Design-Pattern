namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaFactory = new PizzaFactory();
            var pizzaVerity = pizzaFactory.CreatePizza("standard");
            pizzaVerity.Prepare();
        }
    }
}
