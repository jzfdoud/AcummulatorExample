using System;

namespace Accumulator2
{
    class Program
    {
        static void Main(string[] args)
        {
     
            var ans = 0;
            for (var nbr = 0; nbr <= 50; nbr++) { 
            if (nbr % 5 == 0 || nbr % 7 == 0)
                    ans += nbr;
            }
            Console.WriteLine($"This is the sum of numbers 1 to 50 divisable by 5 or 7 : {ans}");
        }
    }
}
