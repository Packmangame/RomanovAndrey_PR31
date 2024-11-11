﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanov_Andrey_PR_31_zd_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SnowMans = 0;
            string[] line = File.ReadAllLines("input.txt");
            SnowMans = int.Parse(line[0]);
            int[] SnowBols=new int[SnowMans*2];
            for (int i=0;i<SnowBols.Length;i++)
            {
                SnowBols[i] = int.Parse(line[1].Substring(0, line[1].IndexOf(' ')));
                line[1]=line[1].Remove(0,3);
            }
            int[] temp = SnowBols;

            Array.Sort(SnowBols);

            
            StreamWriter sw = new StreamWriter("output.txt");

            int[][] pairs = new int[SnowMans][];

            for (int i = 0; i <SnowMans; i++)
            {
               
                int lowerIndex = 2 * i; // нижний шар
                int upperIndex = 2 * i + 1; // верхний шар

                
                pairs[i] = new int[] { lowerIndex + 1, upperIndex + 1 };
            }

            
            foreach (var pair in pairs)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{SnowBols[pair[0] - 1]} {SnowBols[pair[1] - 1]}");
                Console.ResetColor();
            }
            sw.Close();


            Console.WriteLine("Press enter");
            Console.Read();
            Environment.Exit(0);
        }
    }
}