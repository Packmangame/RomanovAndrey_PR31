using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanov_Andrey_PR_31_zd_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PetiaLenght, MessLength;
            string[] line = File.ReadAllLines("input.txt");
            PetiaLenght = int.Parse(line[0].Substring(0, line[0].LastIndexOf(' ')));
            MessLength = int.Parse(line[0].Substring(line[0].LastIndexOf(' ')));


            StreamWriter sw = new StreamWriter("output.txt");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.ResetColor();
            sw.WriteLine();
            sw.Close();
            Console.WriteLine("Press enter");
            Console.Read();
            Environment.Exit(0);
        }

    }
}
