// given a number, return the value at that index of the fibonacci sequence

using System;

public class Program
{

	// this method builds the array containing the sequence
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

	// this method only uses the previous 2 values without taking up space with an array
	public static int Fibonacci2(int idx)
	{
		if(idx == 0 || idx == 1)
		{
			return idx;
		}
		int Fib1 = 0;
		int Fib2 = 1;
		int Fib3;
		for(int i=2;i<=idx;i++)
		{
			Fib3 = Fib1 + Fib2;
			Fib1 = Fib2;
			Fib2 = Fib3;
		}
		return Fib2;
	}

	public static void Main(string[] args)
	{
		// test cases  ex. fib sequence [0,1,1,2,3,5,8,13,21,34]
		Console.WriteLine(Fibonacci(0));
		Console.WriteLine(Fibonacci(1));
		Console.WriteLine(Fibonacci(2));
		Console.WriteLine(Fibonacci(5));
		Console.WriteLine(Fibonacci(8));

		Console.WriteLine(Fibonacci2(0));
		Console.WriteLine(Fibonacci2(1));
		Console.WriteLine(Fibonacci2(2));
		Console.WriteLine(Fibonacci2(5));
		Console.WriteLine(Fibonacci2(8));
	}

}