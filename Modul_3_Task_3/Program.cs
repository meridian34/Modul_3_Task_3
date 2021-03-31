using System;

namespace Modul_3_Task_3
{
    public class Program
    {
        public static void Main()
        {
            var first = new FirstVariant();
            var second = new SecondVariant();
            var third = new ThirdVariant();
            Console.WriteLine(first.WaitResult().GetAwaiter().GetResult());
            Console.WriteLine(second.WaitResult().GetAwaiter().GetResult());
            Console.WriteLine(third.WaitResult().GetAwaiter().GetResult());
        }
    }
}
