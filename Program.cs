// Lamda Expression
//using System;
//using System.Reflection.Metadata.Ecma335;
//namespace lambdaExpression
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Func<int, int> square = x => x * x;
//            Console.WriteLine(square(7));
//        }
//    }
//}

// Exception Handling
//using System;
//namespace exceptionHandling
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
            


//            try
//            {
//                Console.WriteLine("Enter 1st number : ");
//                int x = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter 2nd number : ");
//                int y = int.Parse(Console.ReadLine());
//                int z = x / y;
//                Console.WriteLine(z); 
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Please enter the valid input...");
//            }
//            catch (DivideByZeroException)
//            {
//                Console.WriteLine("Cannot divide the number by zero");
//            }
//            catch(Exception)
//            {
//                Console.WriteLine("Please Try again ...");
//            }

//        }
//    }
//}