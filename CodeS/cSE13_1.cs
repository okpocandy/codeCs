﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeS
{
    delegate int MyDelegate(int a, int b);
    internal class cSE13_1
    {
        static void Main(string[] args)
        {
            MyDelegate Callback;

            Callback = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(Callback(3, 4));
            Callback = delegate (int a, int b)
            {
                return a - b;
            };
            Console.WriteLine(Callback(7,5));
           
        }
    }
}
