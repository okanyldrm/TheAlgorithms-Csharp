using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var data=Console.ReadLine();
            var intData = Int32.Parse(data);
            Console.WriteLine(Fib(intData));
        }

        public static int Fib(int n)
        {

            if (n==0)
            {
                return 0;
            }
            else if(n==1)
            {
                return 1;
            }
            return Fib(n - 2) + Fib(n - 1);

        }
    }
}
