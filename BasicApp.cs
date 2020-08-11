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

        string DecimalConvertTo(string mode, int value)
        {
            string result = "";
            switch (mode)
            {
                case "binary":
                    result = Convert.ToString(value, 2);
                    break;
                case "octal":
                    result = Convert.ToString(value, 8);
                    break;
                case "hexadecimal":
                    result = "0x" + Convert.ToString(value, 16).ToUpper();
                    break;
            }
            return result;
        }

        public void DecimalConverter()
        {
            try
            {
                bool ProcessEnded = false;
                Console.WriteLine("Welcome to DECIMAL TO OTHERS CONVERTER for JetOS");

                while (ProcessEnded == false)
                {
                    Console.WriteLine("Which type of number do you want to convert into?");
                    Console.WriteLine("\t0. Binary\n\t1. Octal\n\t2. Hexadecimal\n\n\n3. Exit Program");
                    Console.Write("> ");
                    string num = Console.ReadLine();
                    int command;
                    if (int.TryParse(num, out command) == false)
                    {
                        Console.WriteLine("Please type a valid number value! (Must be integer)");
                    }
                    else
                    {

                        string mode = null;
                        switch (command)
                        {
                            case 0:
                                mode = "binary";
                                break;
                            case 1:
                                mode = "octal";
                                break;
                            case 2:
                                mode = "hexadecimal";
                                break;
                            case 3:
                                Console.WriteLine("Thank you for using the converter! See you soon!");
                                ProcessEnded = true;
                                break;
                            default:
                                Console.WriteLine("Cannot find any functions for conversion assigned to that number. Please try again!");
                                break;

                        }

                        if (mode != null)
                        {
                            bool convertFinished = false;
                            while (convertFinished == false)
                            {
                                Console.WriteLine("Please type your number (must be not less than 0)");
                                Console.Write(">> ");
                                int dec;
                                string input = Console.ReadLine();
                                if (int.TryParse(input, out dec) == true)
                                {
                                    if (dec >= 0)
                                    {
                                        string result = DecimalConvertTo(mode, dec);
                                        Console.WriteLine("Output result: " + result);
                                    }
                                    else
                                    {
                                        Console.WriteLine("CONVERSION FAILED!\nReason: Your input value is a negative integer!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("CONVERSION FAILED!\nReason: Invaild input value!");
                                }

                                Console.WriteLine("Do you want to convert again into the same number type?");
                                Console.WriteLine("Type: 'Y' if you want to, or else type any value to finish.");
                                Console.Write("> ");
                                string com = Console.ReadLine();
                                com = com.Replace(" ", String.Empty);
                                if (com != "Y")
                                {
                                    convertFinished = true;
                                }
                            }

                        }

                    }
                }
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
            }



        }
    }
}