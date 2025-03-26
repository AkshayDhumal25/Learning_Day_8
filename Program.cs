// Lamda Expression
using System;
using System.Reflection.Metadata.Ecma335;
namespace lambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(7));
        }
    }
}