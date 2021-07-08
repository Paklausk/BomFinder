using System;
using System.IO;
using System.Linq;

namespace BomFinder
{
    class Program
    {
        static byte[] bom = { 0xEF, 0xBB, 0xBF };
        static long foundFiles = 0;
        static void Main(string[] args)
        {
            FileVisitor(Environment.CurrentDirectory);
            if (foundFiles == 0)
                Console.WriteLine("Nothing found");
            Console.ReadKey(true);
        }
        static void FileVisitor(string directory)
        {
            string[] files = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
                if (IsBomFile(file))
                {
                    Console.WriteLine(file);
                    foundFiles++;
                }
        }
        static bool IsBomFile(string file)
        {
            long size = new FileInfo(file).Length;
            if (size > 2)
            {
                byte[] bytes = new byte[3];
                FileStream stream = File.OpenRead(file);
                stream.Read(bytes, 0, bytes.Length);
                stream.Close();
                stream.Dispose();
                return bytes.SequenceEqual(bom);
            }
            return false;
        }
    }
}
