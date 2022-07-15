using System;
using MyMaths;
namespace JenkinsApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter 1 number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2 number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            MyMathsClass myMathsClass = new MyMathsClass();
            Console.WriteLine("addition = " + myMathsClass.Add(a, b));
            Console.WriteLine("addition = " + myMathsClass.Mul(a, b));

            Console.ReadLine();
        }
    }
}
