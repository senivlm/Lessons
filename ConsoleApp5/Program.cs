using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("введите первое число");
            string a1 = Console.ReadLine();
            Console.WriteLine("введите второе число");
            string b1 = Console.ReadLine();
            Console.WriteLine("введите третье число");
            string c1 = Console.ReadLine();
            int a = Convert.ToInt32(a1);
            int b = Convert.ToInt32(b1);
            int c = Convert.ToInt32(c1);

            int summa = a + b + c;
            int proizved = a * b * c;

            Console.WriteLine("сумма = " + summa + " произведение = " + proizved);
        }

    }
}