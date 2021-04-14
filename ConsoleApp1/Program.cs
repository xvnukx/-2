using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите URL директории: ");

                string path = Console.ReadLine();
                var kek = GetF(path);
                Getss(path);
                Console.WriteLine($"Размер папки {kek} байт");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Getss(string path)
        {

            if (Directory.Exists(path))
            {
                string[] dir = Directory.GetDirectories(path);
                foreach (var item in dir)
                {
                    if (Directory.Exists(item))
                    {
                        Getss(item);
                        GetF(item);
                    }

                }


            }

        }
        static long GetF(string path)
        {
            long count = 0;
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo f in files)
            {

                {
                    Console.WriteLine($"{f}, {f.Length}");
                    count += f.Length;
                }

            }

            return count;

        }
    }
}