// Print Odds 1 - 255
// Print all odd integers from 1 to 255.

using System;

public class Program
{

	public static void PrintOdds()
	{
		for(int i=1;i<256;i+=2)
		{
			Console.WriteLine(i);
		}
	}

	public static void Main(string[] args)
	{
		PrintOdds();
	}

}