using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_15_ButtonComand
{
    class PrintCommand: ICommand
    {
        private string _payload = "";

        public PrintCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"Print file {_payload}");
        }
    }
}
