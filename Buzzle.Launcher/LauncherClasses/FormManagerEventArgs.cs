using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Buzzle.GlobalStuff;

namespace Buzzle.Launcher
{
    public class FormManagerEventArgs : EventArgs
    {
        public BuzzleGlobalView FormInQuestion;

        public FormManagerEventArgs(BuzzleGlobalView thisForm)
        {
            FormInQuestion = thisForm;
        }
    }
}
