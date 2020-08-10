using System;
using System.Collections.Generic;
using System.Text;

namespace JetOS
{
    class SystemCmd
    {
        public void Help()
        {
            Console.WriteLine("Welcome to JetOS kernel");
            Console.WriteLine("Try input command to use");
            Console.WriteLine("     help: Shows commands that you can use to interact with.");
            Console.WriteLine("     clear: Clear the screen");
            Console.WriteLine("     exit: Exits JetOS");
            Console.WriteLine("     plus: Adding two numbers.");
            Console.WriteLine("     minus: Subtracting two numbers.");
            Console.WriteLine("     multiply: Multiplying two numbers.");
            Console.WriteLine("     divide: Dividing two numbers.");
            Console.WriteLine("     decconvert: Converting a decimal to other number bases.");
            Console.WriteLine("     reboot: Restarts JetOS");
            Console.WriteLine("     random: Shows random number");
            Console.WriteLine("Powered by Kode Open. Visit: https://https://kodelang.dev/jetos to see the project page.");
        }

        public void Clear()
        {
            Console.Clear();
        }

    }
}
