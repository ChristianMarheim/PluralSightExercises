using System;

namespace FraktalTest
{

    class Program
    {

        

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Action<int> method = Console.WriteLine;

            //CalculateDown(100, method);
            Func<int, int> func = null;
            Func<int, int> functionSquare;
            functionSquare = a =>
            {
                if (a >= 0)
                {
                    Console.WriteLine(a * a);
                    return func(a - 1);
                }
                else return a;
            };
            func = functionSquare;

            func(10);
            functionSquare(10);
            Console.ReadLine();
        }

        private static void Calculate(int stop, Action<int> method)
        {
            if (stop > 0)
            {
                method(stop);
                CalculateDown(stop - 1, method);
            }
        }

        private static void CalculateDown(int stop, Action<int> method)
        {
            if(stop > 0)
            {
                method(stop);
                CalculateDown(stop - 1, method);
            }
        }
    }
}
