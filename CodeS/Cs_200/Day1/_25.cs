using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeS.Cs_200.Day1
{
    internal class _25
    {
        static void Main(string[] args)
        {
            //string 객체는 불변하다. a[0] = 'b'; 이런거 안된다.
            string a = "abc";
            a = "bcd";
            Console.Write(a);
        }
    }
}
