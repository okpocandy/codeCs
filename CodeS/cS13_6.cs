using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeS
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappend;
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if(temp != 0 && temp % 3 == 0)
            {
                SomethingHappend(String.Format("{0} : 짝", number));
            }
        }
    }
    internal class cS13_6
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static public void MyHandler2(string message)
        {
            Console.WriteLine($" Handler 2 : {message}");
        }
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappend += new EventHandler(MyHandler);
            notifier.SomethingHappend += new EventHandler(MyHandler2);

            for (int i=1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
