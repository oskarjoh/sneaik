﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string home;
            string yore_name;
            Console.WriteLine("skriv navnet dit");
           yore_name = Console.ReadLine();
            Console.WriteLine("hallo {0}", yore_name);
            Console.WriteLine("hva vil du jøre nå {0}", yore_name);
            home = Console.ReadLine();
            while (true) { 
                if (home == "help") {
                    Console.WriteLine("welkomen til help");
                    Console.WriteLine("her står alt det du trenger å vite om programet");
                }
            }
        }
    }
}
