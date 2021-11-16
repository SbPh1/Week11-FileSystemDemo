using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\monkey\samples";

            /* string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
             foreach (string dir in dirs)
             {
                 Console.WriteLine(dir);
             }*/
            /*var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
             foreach (string file in files)
             {
                Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                Console.WriteLine(Path.GetFullPath(file));
                Console.WriteLine(Path.GetDirectoryName(file));
                var info = new FileInfo(file);
                
                Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");
              }*/
            //string newPath = @"C:\Users\monkey\samples\Test\Wishlist";
            //Directory.CreateDirectory(newPath);
            /*bool directoryExists = Directory.Exists(newPath);
            if (directoryExists)
            {
                Console.WriteLine("The directory exists");
            }
            else
            {
                Console.WriteLine("The directory does not exist");
                Directory.CreateDirectory(newPath);
            }*/
            //string[] files = Directory.GetFiles(rootPath);
            //string destiantionFolder = @"C:\Users\opilane\samples\Test\Wishlist";
            /*foreach (string file in files)
            {
               Console.WriteLine(file, $"{destiantionFolder}{ Path.GetFileName(file)}", true);
            }*/
            /*for (int i = 0; i < files.Length; i++)
             {
                 File.Copy(files[i], $"{destiantionFolder}{ i }.txt", false);
             }*/
            /*foreach (string file in files)
            {
               File.Move(file, $"{destiantionFolder}{ Path.GetFileName(file)}");
            }*/
            var files = Directory.GetFiles(rootPath, "*wishlist*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
                /*Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                Console.WriteLine(Path.GetFullPath(file));
                Console.WriteLine(Path.GetDirectoryName(file));
                var info = new FileInfo(file);
                
                Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");*/
            }

            Console.ReadLine();

        }
    }
}
