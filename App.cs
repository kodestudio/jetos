using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;


namespace JetOS
{
     /// <summary>
     /// 
     /// </summary>
    class App
    {
        /// <summary>
        /// 
        /// </summary>
        public void Plus()
        {
            Console.WriteLine("Plus App");
            Console.Write("A=");
            float a, b, c;
            string a_input = Console.ReadLine();
            Console.Write("B=");
            string b_input = Console.ReadLine();
            a = float.Parse(a_input);
            b = float.Parse(b_input);
            c = a + b;
            Console.WriteLine("Result: {0}", c.ToString());

        }
    }
}
