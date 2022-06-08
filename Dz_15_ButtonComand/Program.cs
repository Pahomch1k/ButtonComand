using System;
using static System.Console;


namespace Dz_15_ButtonComand
{
    class Program
    {
        static void Main(string[] args)
        { 
            var Binvoker = new ButtonInvoker();
            var Sinvoker = new ShortcutInvoker();

            int flag = 0;
            while (flag == 0)
            {
                WriteLine("1. Button\n2. Shortcut\n3. Exit");
                int choise = Convert.ToInt32(ReadLine());

                switch (choise)
                {
                    case 1: ChoiseB(Binvoker); break;
                    case 2: ChoiseS(Sinvoker); break; 
                    default: flag++; break;
                } 
            }  
        }

        public static void ChoiseB(ButtonInvoker Binvoker)
        {
            int flag = 0;
            while (flag == 0)
            {
                WriteLine("1. Save\n2. Open\n3. Print\n4. Exit");
                int choise = Convert.ToInt32(ReadLine());

                switch (choise)
                {
                    case 1: Binvoker.SetOnSave(new SaveCommand("test.txt")); break;
                    case 2: Binvoker.SetOnOpen(new OpenCommand("test.txt")); break;
                    case 3: Binvoker.SetOnPrint(new PrintCommand("test.txt")); break; 
                    default: flag++; break;
                } 
            }
        }

        public static void ChoiseS(ShortcutInvoker Sinvoker)
        {
            int flag = 0;
            while (flag == 0)
            {
                WriteLine("1. Save\n2. Open\n3. Print\n4. Exit");
                int choise = Convert.ToInt32(ReadLine());

                switch (choise)
                {
                    case 1: Sinvoker.SetOnSave(new SaveCommand("test.txt")); break;
                    case 2: Sinvoker.SetOnOpen(new OpenCommand("test.txt")); break;
                    case 3: Sinvoker.SetOnPrint(new PrintCommand("test.txt")); break;  
                    default: flag++; break;
                } 
            }
        }
    }
}
