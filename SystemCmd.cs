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
            Console.WriteLine("     help: show command can use");
            Console.WriteLine("     clear: clear screen");
            Console.WriteLine("     exit: exit JetOS");
            Console.WriteLine("     plus: use plus program");
            Console.WriteLine("     reboot: restart JetOS");
            Console.WriteLine("Powered by Kode Open. Visit: https://https://kodelang.dev/jetos to see project page");
        }

        public void Clear()
        {
            Console.Clear();
        }

    }
}
