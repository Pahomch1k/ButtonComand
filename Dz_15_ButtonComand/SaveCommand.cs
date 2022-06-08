using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_15_ButtonComand
{
    class SaveCommand: ICommand
    {
        private string _payload = "";

        public SaveCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"Save file {_payload}");
        }
    }
}
