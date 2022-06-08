using System;

namespace MethodsOverload
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        { 
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if(isTrue && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(isTrue && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            var answer = Add(5, 7);

            Console.WriteLine(answer);

            var decimalAnswer = Add(3.7m, 9.1m);

            Console.WriteLine($"decimalAnswer: {decimalAnswer}");

            Console.WriteLine($"Direct WriteLine: {Add(29, 55)}");

            var thirdAnswer = Add(8, 3, false);
            Console.WriteLine($"thirdAnswer (false): {thirdAnswer}");

            var fourthAnswer = Add(1, 0, true);
            Console.WriteLine($"1: {fourthAnswer}");

            Console.WriteLine($"{Add(6, 4, true)}");
        }

    }
}
