using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TreeDirectory;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       ______Directory Tree Creator ______\n");
            Console.WriteLine("Please enter the location path of the folder,");
            Console.WriteLine("which Directory Tree Yoy want to create.");
            Console.Write("Location path format: C:\\Users\\User\\Desktop\\translate.txt): ");

            string path = Console.ReadLine();
            Console.WriteLine("\nThe directory tree of " + path + " is: \n");
            path.Scan("");
            string[] fi = Directory.GetFiles(path);
            foreach (string dir in fi)
            {
                Console.WriteLine("-" + dir);
            }
            Console.ReadKey();
        }
    }
}
