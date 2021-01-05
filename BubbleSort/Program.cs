using System;
using System.Collections.Generic;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>(){1,4,33,7,11,26,72,71,70,69,55};

            int curr;

            for (int j=0;j<=numbers.Count-2;j++)
            {
                for (int i=0; i <= numbers.Count-2;i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        curr = numbers[i+1];
                        numbers[i+1] = numbers[i];
                        numbers[i] = curr;
                    }
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }








        }
    }
}
