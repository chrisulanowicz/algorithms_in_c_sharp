using System;

public class Program
{

	public static int Fibonacci(int idx)
	{
		if(idx == 0 || idx == 1)
		{
			return idx;
		}
		return Fibonacci(idx-1) + Fibonacci(idx-2);
	}

	public static void Main(string[] args)
	{
		// test cases  ex. fib sequence [0,1,1,2,3,5,8,13,21,34]
		Console.WriteLine(Fibonacci(0));
		Console.WriteLine(Fibonacci(1));
		Console.WriteLine(Fibonacci(2));
		Console.WriteLine(Fibonacci(5));
		Console.WriteLine(Fibonacci(8));
	}

}