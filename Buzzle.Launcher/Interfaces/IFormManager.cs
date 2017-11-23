using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buzzle.GlobalStuff;

namespace Buzzle.Launcher
{
    public interface IFormManager
    {
        event EventHandler FormAdded;
        event EventHandler FormClosed;
        event EventHandler CurrentFormChanged;

        void OpenForm(BuzzleGlobalView thisForm, bool CloseAnyExistingInstance = false);

        void CloseForm(BuzzleGlobalView thisForm);

        bool IsCurrentForm(BuzzleGlobalView thisForm);

        bool FormIsOpen(BuzzleGlobalView thisForm);

        BuzzleGlobalView GetCurrentForm();

        void SetAsCurrentForm(BuzzleGlobalView thisForm);

        void UnSetAsCurrentForm(BuzzleGlobalView thisForm);

    }
}
