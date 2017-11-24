using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Buzzle.Client.Ui;

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
