using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace JetOS
{
    class SystemCmd
    {
        public void Help()
        {
            Console.WriteLine("Welcome to JetOS Kernel");
            Console.WriteLine("Try input command to use");
            Console.WriteLine("     help: Show commands that you can use to interact with");
            Console.WriteLine("     clear: Clear the screen");
            Console.WriteLine("     dir: Show current directory");
            Console.WriteLine("     mkdir: Create directory");
            Console.WriteLine("     rmvdir: Delete directory");
            Console.WriteLine("     tree: View the directory's file tree");
            Console.WriteLine("     rnm: Rename a directory");
            Console.WriteLine("     shutdown: Shutdown JetOS");
            Console.WriteLine("     plus: Add two numbers");
            Console.WriteLine("     minus: Subtract two numbers");
            Console.WriteLine("     multiply: Multiply two numbers");
            Console.WriteLine("     divide: Divide two numbers");
            Console.WriteLine("     decconvert: Convert a decimal to other number bases");
            Console.WriteLine("     reboot: Restart JetOS");
            Console.WriteLine("     random: Show random number");
            Console.WriteLine("     say: Just say something!");
            Console.WriteLine("Powered by Kode Open. Visit: https://https://kodelang.dev/jetos to see the project page.");
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Reboot()
        {
            Sys.Power.Reboot();
        }

        public void Shutdown()
        {
            Sys.Power.Shutdown();
        }

    }
}
