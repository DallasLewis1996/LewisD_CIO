﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC160_ConsoleMenu;

namespace LibTester
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] lol = { "start game", "setting", "difficulty" };
            Console.WriteLine(CIO.PromptForMenuSelection(lol,false));

            
        }
    }
}
