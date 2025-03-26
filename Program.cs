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

// Async and Await
//using System;
//using System.Diagnostics;
//namespace AsynchronousProgramming
//{
//    public class AsyncAwaitPart1
//    {
//        public static void Method1()
//        {
//            Thread.Sleep(3500);
//            Console.WriteLine("Method1 Executed");
//        }
//        public static void Method2()
//        {
//            Thread.Sleep(3500);
//            Console.WriteLine("Method2 Executed");
//        }
//        public static void Method3()
//        {
//            Thread.Sleep(3500);
//            Console.WriteLine("Method3 Executed");
//        }

//        static void Main(string[] args)
//        {
//            Stopwatch stopwatch = new Stopwatch();
//            stopwatch.Start();
//            Method1();
//            Method2();
//            Method3();
//            stopwatch.Stop();
//            var timeElapsed = stopwatch.ElapsedMilliseconds;
//            Console.WriteLine("Time take for execution of all 3 methods :" + timeElapsed);
//        }
//    }
//}
//Method1 Executed
//Method2 Executed                                        by Sync
//Method3 Executed
//Time take for execution of all 3 methods :10542




//using Aync and Await Method
//using System;
//using System.Diagnostics;
//namespace AsynchronousProgramming
//{
//    public class AsyncAwaitPart1
//    {
//        public static async Task Method1()
//        {
//            await Task.Delay(7000);
//            //Thread.Sleep(3500);
//            Console.WriteLine("Method1 Executed");
//        }
//        public static async Task  Method2()
//        {
//            await Task.Delay(3500);
//            //Thread.Sleep(3500);
//            Console.WriteLine("Method2 Executed");
//        }
//        public static async Task Method3()
//        {
//            await Task.Delay(9000);
//            //Thread.Sleep(3500);
//            Console.WriteLine("Method3 Executed");
//        }

//        static void Main(string[] args)
//        {
//            Stopwatch stopwatch = new Stopwatch();
//            stopwatch.Start();
//            Task.WaitAll(Method1(), Method2(), Method3());
//            //Method1();
//            //Method2();
//            //Method3();
//            stopwatch.Stop();
//            var timeElapsed = stopwatch.ElapsedMilliseconds;
//            Console.WriteLine("Time take for execution of all 3 methods :" + timeElapsed);
//        }
//    }
//}
//Method2 Executed
//Method1 Executed
//Method3 Executed
//Time take for execution of all 3 methods :9018


