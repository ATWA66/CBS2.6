using System;

namespace ConsoleApp56
{
    static class Calculator
    {
        public static double plus(double a, double b) => a + b;
        public static double minus(double a, double b) => a - b;
        public static double del(double a, double b) => a / b;
        public static double ymn (double a, double b) => a * b;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your operands  a:");
            double a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your operands  b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("basic math operations: +, -, /, *");
            Console.WriteLine(Calculator.plus(a,b));
            Console.WriteLine(Calculator.minus(a,b));
            Console.WriteLine(Calculator.del(a,b));
            Console.WriteLine(Calculator.ymn(a,b));
        }
    }
}
