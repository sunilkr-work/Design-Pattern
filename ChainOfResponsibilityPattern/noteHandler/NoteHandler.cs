using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.noteHandler
{
    internal class NoteHandler
    {
        public NoteHandler next { get; set; }

        public NoteHandler() {
            next = null;
        }


        public virtual void ValidateAndWithdraw(int amount) { }
        public void SetNext(NoteHandler nextHandler)
        {
            this.next = nextHandler;
        }

    }
}
