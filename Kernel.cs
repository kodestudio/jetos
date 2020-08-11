using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sys = Cosmos.System;

namespace JetOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            // init file system
            SystemProcess systemprocess = new SystemProcess();
            systemprocess.InitFileSystem();
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
            string func = "";
            var input = Console.ReadLine();
            // Call App Class
            BasicApp CallBasicApp = new BasicApp();
            // Connect to system cmd
            SystemCmd CMD = new SystemCmd();
            SystemUtils Utilities = new SystemUtils();
            TextFile textfile = new TextFile();

            if (input.Split().Length > 1)
            {
                func = input.Split()[0];
            } else
            {
                func = input;
            }
            
            switch (func)
            {
                case "help":
                    CMD.Help();
                    break;
                case "clear":
                    CMD.Clear();
                    break;
                case "reboot":
                    CMD.Reboot();
                    break;
                case "shutdown":
                    CMD.Shutdown();
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
                case "decconvert":
                    CallBasicApp.DecimalConverter();
                    break;
                case "create":
                    textfile.CreateFile();
                    break;
                case "read":
                    textfile.Read();
                    break;
                case "write":
                    textfile.Write();
                    break;
                case "dir":
                    Utilities.InspectDirectory();
                    break;
                case "mkdir":
                    Utilities.CreateDirectory();
                    break;
                case "cd":
                    Utilities.GoToDirectory();
                    break;
                case "rnm":
                    Utilities.RenameDirectory();
                    break;
                case "say":
                    int i = 0; string speech = "";
                    if (input.Split().Length > 1)
                    {
                        for (i = 1; i < input.Split().Length; i++)
                        {
                            speech += input.Split()[i];
                            if (i < input.Split().Length - 1)
                            {
                                speech += " ";
                            }

                        }
                        Utilities.Say(string.Join(" ", speech));
                    } else
                    {
                        Utilities.Say("Can't hear you...");
                    } 
                    break;
                default:
                    Console.WriteLine("Unknow command. Try 'help' to see command can use");
                    break;
            }
        }
    }
}
