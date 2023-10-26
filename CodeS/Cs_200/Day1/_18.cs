using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeS.Cs_200.Day1
{
    internal class _18
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue, y = 0;

            //checked 를 사용하면 overflow 예외를 발생시키고, 값은 0이 들어감.
            //default는 unchecked.
            //unchecked 로 하면 overflow가 진행된 값이 들어가고 예외도 발생안함.
            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            

            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}
