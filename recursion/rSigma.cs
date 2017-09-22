//  given a number, return the sum of all integers incremented by one up to the number
//  ex. given 5 return 15 (1+2+3+4+5 = 15)
//  if given a negative number just return 0

using System;

public class Program
{

	public static int Sigma(int num)
	{
		if(num < 1)
		{
			return 0;
		}
		return num + Sigma(num-1);
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(Sigma(0));
		Console.WriteLine(Sigma(1));
		Console.WriteLine(Sigma(2));
		Console.WriteLine(Sigma(5));
	}

}