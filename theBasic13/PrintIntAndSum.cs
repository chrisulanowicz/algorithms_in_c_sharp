// Print integers from 0 to 255, and with each integer print the sum so far.
// ex. Current integer: 2. Running sum: 3.
using System;

public class Program
{

	public static void PrintIntsAndSum()
	{
		int Sum = 0;
		for(int i=0;i<256;i++)
		{
			Sum += i;
			Console.WriteLine($"Current Integer: {i}, Running Sum: {Sum}");
		}
	}

	public static void Main(string[] args)
	{
		PrintIntsAndSum();
	}

}