using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeS.Cs_200.Day1
{
    internal class _26
    {
        static void Main(string[] args)
        {
            Console.Write("더하고자 하는 숫자들을 입력하세요: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            foreach(var i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과는 {0}", sum);
        }
    }
}
