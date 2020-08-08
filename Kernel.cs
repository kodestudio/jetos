using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace JetOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("JetOS booted successfully.");
            Console.WriteLine(@"       _      _    ____   _____ ");
            Console.WriteLine(@"      | |    | |  / __ \ / ____|");
            Console.WriteLine(@"      | | ___| |_| |  | | (___  ");
            Console.WriteLine(@"  _   | |/ _ \ __| |  | |\___ \ ");
            Console.WriteLine(@" | |__| |  __/ |_| |__| |____) |");
            Console.WriteLine(@"  \____/ \___|\__|\____/|_____/ ");
        }

        protected void Help()
        {
            Console.WriteLine("Welcome to JetOS kernel");
            Console.WriteLine("Try input command to use");
            Console.WriteLine("     help: show command can use");
            Console.WriteLine("     clear: clear screen");
            Console.WriteLine("     exit: exit JetOS");
            Console.WriteLine("     plus: use plus program");
            Console.WriteLine("     reboot: restart JetOS");
            Console.WriteLine("Powered by Kode Open. Visit: https://https://kodelang.dev/jetos to see project page");
        }

        protected void Clear()
        {
            Console.Clear();
        }

        protected override void Run()
        {
            Console.Write("JetOS>");
            var input = Console.ReadLine();
            // Call App Class
            App CallApp = new App();
            switch (input)
            {
                case "help":
                    Help();
                    break;
                case "clear":
                    Clear();
                    break;
                case "reboot":
                    Clear();
                    BeforeRun();
                    break;
                case "plus":
                    CallApp.Plus();
                    break;
                default:
                        Console.WriteLine("Unknow command. Try 'help' to see command can use");
                    break;
            }    
        }
    }
}
