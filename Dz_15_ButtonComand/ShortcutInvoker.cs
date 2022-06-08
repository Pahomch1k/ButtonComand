using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_15_ButtonComand
{
    class ShortcutInvoker
    {
        private ICommand _onSave;

        private ICommand _onOpen;

        private ICommand _onPrint;


        // Инициализация команд
        public void SetOnSave(ICommand command)
        {
            _onSave = command;
            if (_onSave is SaveCommand) _onSave.Execute();
        }

        public void SetOnOpen(ICommand command)
        {
            _onOpen = command;
            if (_onOpen is OpenCommand) _onOpen.Execute();
        }

        public void SetOnPrint(ICommand command)
        {
            _onPrint = command;
            if (_onPrint is PrintCommand) _onPrint.Execute();
        } 
    }
}
