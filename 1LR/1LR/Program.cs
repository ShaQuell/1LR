using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{

    delegate int Sum(int number);
    class Program
    {
        static Sum A1()
        {
            int result = 0;
            Sum del = delegate (int number)
            {
                int n1 = 3;
                int n2 = 9;
                int n3 = 12;
                result = (n1 + n2 + n3) / 3;
                return result;
            };
            return del;
        }

        static void Main()
        {
            Sum del1 = A1();

            Console.WriteLine("Середнє значення чисел дорівнює: {1}", result);
            Console.ReadLine();
        }
    }
}
