using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Romanov_Andrey_PR_31_zd_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //circule race
            int S=0, V=0, t = 0;
            string[] line = File.ReadAllLines("input.txt");
            S = int.Parse(line[0]);
            t = int.Parse(line[1].Substring(line[1].LastIndexOf(' ')));
            V = int.Parse(line[1].Substring(0,line[1].LastIndexOf(' ')));
           

            StreamWriter sw = new StreamWriter("output.txt");
            
            int K = (V * t);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Car stopped before {K} km");
            Console.ResetColor();
            sw.WriteLine(K);
            sw.Close();
            Console.WriteLine("Press any buttons");
            Console.Read();
            Environment.Exit(0);

        }
    }
}
