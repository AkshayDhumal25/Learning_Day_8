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

// Logicals
//4.Find the reverse of the string.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";
//            string reverse = "";
//            for(int i = str.Length - 1; i >= 0; i--)
//            {
//                reverse += str[i];
//            }
//            Console.WriteLine(reverse);

//        }
//    }
//}


//5. WAP to find missing elements from the array?
//using System;
//namespace logicals
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, 5, 6 };
//            int n = arr.Length + 1;
//            int totalSum = (n * (n + 1) / 2);
//            int currSum = 0;
//            foreach(int i in arr)
//            {
//                currSum += i;
//            }

//            Console.WriteLine(totalSum - currSum);
//        }
//    }
//}

//6.WAP to find the given string is Palindrome or not.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string str = "abbaa";
//            int left = 0;
//            int right = str.Length - 1;
//            bool palindrome = true;
//            while(left < right)
//            {
//                if (str[left] == str[right])
//                {
//                    //continue;
//                    left++;
//                    right--;
//                    palindrome = true;
//                }
//                else
//                {
//                    palindrome = false;
//                }
//            }

//            if (palindrome)
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("Not Palindrome");
//            }
//        }
//    }
//}


//7.WAP to print Fibonacci series with recursion.
//using System;
//namespace Logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            var n = Convert.ToInt32(Console.ReadLine());

//            PrintFibonacciSeries(n);


//        }

//        static void PrintFibonacciSeries(int n)
//        {
//            for (int i = 1; i <= n; i++)
//            {
//                Console.Write(Fibonacci(i) + " ");
//            }
//        }
//        public static int Fibonacci(int n)
//        {
//            if (n <= 0)
//            {
//                Console.WriteLine("Input must be a positive integer.");
//                return -1;
//            }
//            else if (n == 1)
//                return 0;
//            else if (n == 2)
//                return 1;
//            else
//                return Fibonacci(n - 1) + Fibonacci(n - 2);

//        }
//    }
//}


//8. WAP to print Fibonacci series without recursion.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            Fibonacci(n);
//        }


//        public static void Fibonacci(int n)
//        {
//            int a = 0;
//            int b = 1;
//            int c = 0;
//            Console.Write(a + " " + b + " ");
//            for (int i = 2; i < n; i++) // Start from index 2
//            {
//                c = a + b;
//                Console.Write(c + " "); // Print next Fibonacci number
//                a = b;
//                b = c; // Update for next iteration
//            }
//        }
//    }
//}


//10.Code to find even numbers in a list
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {

//            var list = new List<int>() {1,2,3,4,5,6,7 };
//            for(int i = 0; i < list.Count; i++)
//            {
//                if (isPrime(list[i]))
//                {
//                    Console.Write(list[i] + " ");
//                }
//                else
//                {
//                    Console.Write("N" + " ");
//                }
//            }
//            //Console.WriteLine("Enter the number : ");
//            //int n = Convert.ToInt32(Console.ReadLine());
//            //if (isPrime(n))
//            //{
//            //    Console.WriteLine("Prime Number");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Not Prime Number");
//            //}
//        }
//        public static bool isPrime(int n)
//        {
//            if (n < 2) return false;
//            if (n == 2) return true;
//            if (n % 2 == 0) return false;

//            for(int i=3; i * i < n; i++)
//            {
//                if (n % i == 0) return false;
//            }
//            return true;

//        }
//    }
//}

// Generics
//using System;
//namespace generics 
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the X value to swap");
//            var x = Console.ReadLine();
//            Console.WriteLine("Enter the Y value");
//            var y = Console.ReadLine();
//            swap(x, y);


//        }

//        public static void swap<T> (T x, T y)
//        {
//            var temp = x;
//            x = y;
//            y = temp;

//            Console.WriteLine($"X : {x} and Y : {y}");
//            Console.ReadLine();
//        }
//    }

//}

// Method Overloading and Method Overrinding
//using System;
//namespace methodOcerloading
//{
//    class MathOperations
//    {
//        public int add(int x , int y)
//        {
//            return x + y;
//        }
//        public int add(int x, int y, int z)
//        {
//            return x + y + z;
//        }
//        public double add(double x, double y)
//        {
//            return x + y;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MathOperations ops = new MathOperations();
//            Console.WriteLine(ops.add(1, 2));
//            Console.WriteLine(ops.add(1, 2,3));
//            Console.WriteLine(ops.add(1.0, 2.5));

//        }
//    }
//}


// Method Overriding
//using System;
//namespace methodOverriding
//{

//    class A
//    {
//        public virtual void show()
//        {
//            Console.WriteLine("Class A");
//        }
//    }

//    class B : A
//    {
//        public override void show()
//        {
//            Console.WriteLine("class B");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            A a = new A();
//            a.show();

//            B b = new B();
//            b.show();


//        }
//    }
//}

// Abstract Class
//namespace AbstractProject
//{
//    abstract class AbsParent
//    {
//        public abstract void Add(int x, int y);
//    }

//    class AbsChild : AbsParent
//    {
//        public override void  Add(int x, int y)
//        {
//            Console.WriteLine(x + y);
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            AbsParent obj = new AbsChild();
//            obj.Add(1, 2);
//        }
//    }
//}

//Properties in C#
//using System;
//namespace properties
//{

//    class Person
//    {
//        private string name;
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person p = new Person();
//            p.Name = "Akshay";
//            Console.WriteLine(p.Name);
//        }
//    }
//}



