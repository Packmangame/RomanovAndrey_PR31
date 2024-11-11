using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Romanov_Andrey_PR_31_zd_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fishing
            int k,n,ans;

            string[] line = File.ReadAllLines("input.txt");
            k = int.Parse(line[0].Substring(0,line[0].IndexOf(' ')));
            n = int.Parse(line[0].Substring(line[0].LastIndexOf(' ')));
            

            StreamWriter sw = new StreamWriter("output.txt");
            ans = Math.Abs(n / k);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ans);
            Console.ResetColor();
            sw.WriteLine(ans);
            sw.Close();

            Console.WriteLine("Press any buttons");
            Console.Read();
            Environment.Exit(0);
        }
    }
}
