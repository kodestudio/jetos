using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;


namespace JetOS
{
     /// <summary>
     /// 
     /// </summary>
    class BasicApp
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
            Console.WriteLine("Output: {0}", c.ToString());

        }

        public void Multiply()
        {
            Console.WriteLine("Multiply App");
            Console.Write("A=");
            float a, b, c;
            string a_input = Console.ReadLine();
            Console.Write("B=");
            string b_input = Console.ReadLine();
            a = float.Parse(a_input);
            b = float.Parse(b_input);
            c = a * b;
            Console.WriteLine("Output: {0}", c.ToString());

        }
        public void Minus()
        {
            Console.WriteLine("Minus App");
            Console.Write("A=");
            float a, b, c;
            string a_input = Console.ReadLine();
            Console.Write("B=");
            string b_input = Console.ReadLine();
            a = float.Parse(a_input);
            b = float.Parse(b_input);
            c = a - b;
            Console.WriteLine("Output: {0}", c.ToString());

        }

        public void Divide()
        {
            Console.WriteLine("Divide App");
            Console.Write("A=");
            float a, b, c;
            string a_input = Console.ReadLine();
            Console.Write("B=");
            string b_input = Console.ReadLine();
            a = float.Parse(a_input);
            b = float.Parse(b_input);
            c = a / b;
            Console.WriteLine("Output: {0}", c.ToString());

        }

        public void RandomApp()
        {
            Random ran = new Random();
            Console.WriteLine("Output: {0}", ran.ToString());
        }
    }
}
