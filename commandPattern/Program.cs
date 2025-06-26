using commandPattern.command;
using commandPattern.invoker;
using commandPattern.receiver;

namespace commandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            LightCommand lightComman = new LightCommand(new Light());
            FanCommand fanComman = new FanCommand(new Fan());
            var remote = new RemoteController();

            remote.SetCommand(0,fanComman);
            remote.SetCommand(1, lightComman);

            remote.PressButton(0); // Execute Fan Command
            remote.PressButton(0);
        }
    }
}
