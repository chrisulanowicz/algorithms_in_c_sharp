//get the product of all integers from 1 up to specified value
using System;

public class Program
{

	public static int Factorial(int num)
	{
		if(num < 2)
		{
			return 1;
		}
		return num * Factorial(num-1);
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(Factorial(0));
		Console.WriteLine(Factorial(1));
		Console.WriteLine(Factorial(2));
		Console.WriteLine(Factorial(5));
		Console.WriteLine(Factorial(8));
	}

}