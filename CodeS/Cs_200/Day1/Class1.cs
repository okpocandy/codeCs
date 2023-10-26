using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeS.Cs_200.Day1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.Write("1. int 로 변환할 문자열을 입력하세요 :");
            input = Console.ReadLine();
            //TryParse() 는 해보고 성공하면 True, 실패하면 False 반환
            bool result = Int32.TryParse(input, out value);

            if (!result)
                Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.\n", input);
            else
                Console.WriteLine("int '{0}'으로 변환되었습니다.\n", value);

            Console.Write("2. double로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine() ;
            //Pares()는 변환실행, 오류 발생할 수 있음 발생하면 try, catch 문으로 오류를 알린다
            try
            {
                double m = double.Parse(input);
                Console.WriteLine("double '{0}'으로 변환되었습니다.\n", m);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
