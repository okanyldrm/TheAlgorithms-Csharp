using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var inputData = Console.ReadLine();
            IsPolindrome(inputData);
        }



        public static void IsPolindrome(string numberStr)
        {
            
            if (numberStr.Length%2==0)
            {
                var firstHalf = numberStr.Substring(0, numberStr.Length / 2);
                var secondHalf = numberStr.Substring(numberStr.Length / 2, numberStr.Length / 2);
                
                char[] secondHalff = secondHalf.ToCharArray();
                Array.Reverse(secondHalff);
                var reverseSecond = new string(secondHalff);
                if (reverseSecond==firstHalf)
                {
                    Console.WriteLine("IsPalindrome");
                }
                else
                {
                    Console.WriteLine("IsNotPalindrome");
                }
                
            }

            else
            {
                double half = numberStr.Length / 2;
                var firstHalf = numberStr.Substring(0, (int)Math.Floor(half));
                var secondHalf = numberStr.Substring((int)Math.Ceiling(half)+1,(int)Math.Floor(half));

                char[] secondHalff = secondHalf.ToCharArray();
                Array.Reverse(secondHalff);
                var reverseSecond = new string(secondHalff);
                if (firstHalf==reverseSecond)
                {
                    Console.WriteLine("IsPalindrome");
                }
                else
                {
                    Console.WriteLine("IsNotPalindrome");
                }
            }
           
           
        }






    }
}
