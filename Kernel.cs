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

   
        protected override void Run()
        {
            Console.Write("JetOS>");
            var input = Console.ReadLine();
            // Call App Class
            App CallApp = new App();
            // Connect to system cmd
            
            SystemCmd CMD = new SystemCmd();
            switch (input)
            {
                case "help":
                    CMD.Help();
                    break;
                case "clear":
                    CMD.Clear();
                    break;
                case "reboot":
                    CMD.Clear();
                    BeforeRun();
                    break;
                case "plus":
                    CallApp.Plus();
                    break;
                case "multiply":
                    CallApp.Multiply();
                    break;
                case "minus":
                    CallApp.Minus();
                    break;
                case "divide":
                    CallApp.Divide();
                    break;
                default:
                    Console.WriteLine("Unknow command. Try 'help' to see command can use");
                    break;
            }    
        }
    }
}
