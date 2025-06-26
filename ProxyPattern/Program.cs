namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = "A";
            string size = "100x100";
            user user = new user();
            ProxyImage proxyImage = user.GetImage(name, size);
            proxyImage.CompressImage();

        }
    }
}
