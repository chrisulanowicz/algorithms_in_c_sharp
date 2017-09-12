// given an integer
// respond with the integer itself if it's not divisible by 5 or 3
// respond with "Fizz" if the integer is evenly divisible by 5
// respond with "Buzz" if the integer is evenly divisible by 3
// respond with "FizzBuzz" if the integer is even divisible by both 5 and 3

using System;

public class Program
{

	public static string fizzBuzz(int val)
        {
            if(val % 3 == 0 && val % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if(val % 3 == 0)
            {
                return "Fizz";
            }
            else if(val % 5 == 0)
            {
                return "Buzz";
            }
            else 
            {
                return val.ToString();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(fizzBuzz(15)); // => FizzBuzz
            Console.WriteLine(fizzBuzz(18)); // => Fizz
            Console.WriteLine(fizzBuzz(20)); // => Buzz
            Console.WriteLine(fizzBuzz(19)); // => 19
        }

}