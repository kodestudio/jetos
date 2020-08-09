using System;
using System.Collections.Generic;
using System.Text;

namespace JetOS
{
    class TextFile
    {
        public void Write()
        {
            //string fileLPath = @"file1.txt";
            string fileSPath = @"file.txt";

            //string[] lines = new string[2];
            //lines[0] = "Write data to file using C#.";
            //lines[1] = ":)";

            //System.IO.File.WriteAllLines(fileLPath, lines);

            string str;
            str = "Write data to file using C#.\r\n:D";

            System.IO.File.WriteAllText(fileSPath, str);
        }

        public void Read()
        {
            string filePath = @"file.txt";
            
            string[] lines;
            string str;

            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine("Line { 0}: { 1} ",i , lines[i]);
                }
            Console.WriteLine();

                str = System.IO.File.ReadAllText(filePath);
                Console.WriteLine("String: {0}", str);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
