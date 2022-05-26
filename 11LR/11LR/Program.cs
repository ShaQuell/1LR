using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11LR
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Це калькулятор. Введіть перше число, бажану операцію та друге число у такому форматі: 15 + 28.\nБудь ласка, ставте пробіли між елементами \nОперації: +: додавання, -: віднімання, *: множення, /: ділення");
            while (true) 
            {
                string s1 = Console.ReadLine();
                String[] expressions = { s1 };
                String pattern = @"(\d+)\s+([-+*/])\s+(\d+)";
                foreach (var expression in expressions) foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(expression, pattern))
                    {
                        int value1 = Int32.Parse(m.Groups[1].Value);
                        int value2 = Int32.Parse(m.Groups[3].Value);
                        switch (m.Groups[2].Value)
                        {
                            case "+":
                                Func<int, int> Add = (x, y) => x + y;
                                Console.WriteLine(Add(value1, value2));
                                break;
                            case "-":
                                Func<int, int> Sub = (x, y) => x - y;
                                Console.WriteLine(Sub(value1, value2));
                                break;
                            case "*":
                                Func<int, int> Mul = (x, y) => x * y;
                                Console.WriteLine(Mul(value1,value2));
                                break;
                            case "/":
                                Func<int, int> Div = (x, y) => x / y;
                                Console.WriteLine(Div(value1, value2));
                                break;
                        }
                }
            }
        }
    }
}
