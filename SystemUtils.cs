using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;

namespace JetOS
{
    class SystemUtils
    {
        string ROOT = @"0:\";
        string RemoveSides(char[] targets, string src)
        {
            int first = 0;
            int last = src.Length - 1;
            int i;
            for (i = 0; i < src.Length; i++)
            {
                if (Array.IndexOf(targets, src[i]) < 0)
                {
                    first = i;
                    break;
                }
            }

            for (i = src.Length - 1; i >= 0; i--)
            {
                if (Array.IndexOf(targets, src[i]) < 0)
                {
                    last = i;
                    break;
                }
            }

            return src.Substring(first, last - first + 1);
        }

        public void InspectDirectory()
        {
            string key = Directory.GetCurrentDirectory();
            Console.WriteLine("Current directory: {0}", key);
        }

        public void CreateDirectory(string dir)
        {
            string currentDir = Directory.GetCurrentDirectory();
            char[] targets = { ' ', '\\' };
            string targetDir = currentDir + RemoveSides(targets, dir) + @"\";
            if (Directory.Exists(targetDir)) {
                Console.WriteLine("Cannot create directory. The path you provided has been exist!");
            } else
            {
                Directory.CreateDirectory(targetDir);
                Console.WriteLine("Successfully created directory: {0}", targetDir);
            }
            
        }

        public void RemoveDirectory(string dir)
        {
            string currentDir = Directory.GetCurrentDirectory();
            char[] targets = { ' ', '\\' };
            string targetDir = currentDir + RemoveSides(targets, dir) + @"\";
            if (!Directory.Exists(targetDir))
            {
                Console.WriteLine("Cannot remove directory. The path you provided doesn't exist!");
            }
            else
            {
                try
                {
                    Directory.Delete(targetDir);
                    Console.WriteLine("Directory has been removed");
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
                
            }
        }

        public void ViewDirectoryTree()
        {
            string currentDir = Directory.GetCurrentDirectory();
            string[] dirs = Directory.GetDirectories(currentDir);
            string[] files = Directory.GetFiles(currentDir);


            int i;
            Console.WriteLine("Contents in directroy: {0}\n", currentDir);
            for (i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine("-> {0}", dirs[i]);
            }
            for (i = 0; i < files.Length; i++)
            {
                Console.WriteLine("{0}", files[i]);
            }
            Console.WriteLine("\n");
        }

        public void RenameDirectory()
        {
            Console.WriteLine("Unavailable");
        }

        public void GoToDirectory(string dirChunk)
        {
            try
            {
                string currentDir = Directory.GetCurrentDirectory();
                char[] targets = { ' ', '\\' };
                string targetDir = currentDir + RemoveSides(targets, dirChunk) + @"\";
                if (Directory.Exists(targetDir))
                {
                    Directory.SetCurrentDirectory(targetDir);
                }
                else if (RemoveSides(targets, dirChunk) == "~") {
                    Directory.SetCurrentDirectory(ROOT);
                }
                else {
                    Console.WriteLine("Cannot find directory: {0}", targetDir);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            
        }

        public void Say(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
