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
            BasicApp CallBasicApp = new BasicApp();
            // Connect to system cmd
            SystemCmd CMD = new SystemCmd();
            TextFile textfile = new TextFile();
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
                    CallBasicApp.Plus();
                    break;
                case "multiply":
                    CallBasicApp.Multiply();
                    break;
                case "minus":
                    CallBasicApp.Minus();
                    break;
                case "divide":
                    CallBasicApp.Divide();
                    break;
                case "random":
                    CallBasicApp.RandomApp();
                    break;
                case "write":
                    textfile.Write();
                    break;
                case "read":
                    textfile.Read();
                    break;
                default:
                    Console.WriteLine("Unknow command. Try 'help' to see command can use");
                    break;
            }    
        }
    }
}
