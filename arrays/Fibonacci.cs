// given a number, return the value at that index of the fibonacci sequence

using System;

public class Program
{

	public static int Fibonacci(int idx)
	{
		int[] FibSequence = new int[idx+1];
		for(int i=0;i<idx+1;i++)
		{
			if(i==0)
			{
				FibSequence[i] = 0;
			}
			else if(i==1)
			{
				FibSequence[i] = 1;
			}
			else
			{
				FibSequence[i] = FibSequence[i-1] + FibSequence[i-2];
			}
		}
		return FibSequence[idx];
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