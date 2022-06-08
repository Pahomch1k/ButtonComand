using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_15_ButtonComand
{
    class OpenCommand: ICommand
    {
        private string _payload = "";

        public OpenCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"Open file {_payload}");
        }
    }
}
