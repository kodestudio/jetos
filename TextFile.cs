using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;
namespace JetOS
{
    class TextFile
    {
        public void CreateFile()
        {
            Console.Write("File Directory: ");
            var usersFile = Console.ReadLine();
            if (File.Exists(usersFile))
            {
                Console.WriteLine("File found at {0}", usersFile);
            }
            else
            {
                File.Create(usersFile);
                Console.WriteLine("File created");
            }
        }

        public void Write()
        {
            Console.Write("File directory: ");
            var FilePath = Console.ReadLine();
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("File not found. Try 'create' to create this file");

            }                
            else
            {
                Console.WriteLine("Input content of file {0}", FilePath);
                Console.WriteLine("====================================================");
                string contentFile;
                string fullText = "";
                Console.Write("> ");
                while (!string.IsNullOrWhiteSpace(contentFile=Console.ReadLine()))
                {
                    Console.Write("> ");
                    fullText += contentFile + "\n";
                }
                File.WriteAllText(FilePath, fullText);
                Console.WriteLine("====================================================");
                Console.WriteLine("Write file complete");
            }                
        }

        public void Read()
        {
            Console.Write("File directory: ");
            var FilePath = Console.ReadLine();
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("File not found. Try 'create' to create this file");

            }
            else
            {
                string fileContent;
                fileContent = File.ReadAllText(FilePath);
                Console.WriteLine("Content of {0}", FilePath);
                Console.WriteLine("====================================================");
                Console.WriteLine(fileContent);
                Console.WriteLine("====================================================");
            }
        }
    }
}
