﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeS.Cs_200.Day1
{
    internal class _3
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.WriteLine("World!");
            Console.Write("이름을 입력하세요 : ");

            string name = Console.ReadLine();
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
