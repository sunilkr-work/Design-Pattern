using commandPattern.command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace commandPattern.invoker
{
    internal class RemoteController
    {
        private static int finalButton = 2;
        IComman[] commands ;
        bool[] isButtonPressed;
        public RemoteController()
        {
            this.commands = new IComman[finalButton];
            this.isButtonPressed = new bool[finalButton];

            for (int i = 0; i < finalButton; i++)
            {
                commands[i] = null;
                isButtonPressed[i] = false;
            }

        }

        public void SetCommand(int id, IComman command)
        {
            if(id>=0 && id<4 )
            {
                commands[id] = command;
                isButtonPressed[id] = false;
            }
            else
            {
                Console.WriteLine("Invalid Command ID");
            }
        }

        public void PressButton(int id)
        {
            if (commands[id] != null)
            {
                if (isButtonPressed[id])
                {
                    commands[id].Undo();
                }
                else
                {
                    commands[id].Execute();
                }
                isButtonPressed[id] = !isButtonPressed[id];
            }
        }




    }
}
