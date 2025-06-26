using ChainOfResponsibilityPattern.noteHandler;

namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var noteHandler = new NoteHandler();
            IATM atm = new ATM(noteHandler);
            atm.Withdraw(3560);
        }
    }
}
