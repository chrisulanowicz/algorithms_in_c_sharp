// Analyze an array's values and print the average.
// ex. [3,5,4] prints 4

using System;

public class Program
{

	public static void PrintAverage(int[] arr)
	{
		double Sum = 0;
		int Len = arr.Length;
		if(Len == 0)
		{
			Console.WriteLine("Array is empty");
			return;
		}
		for(int i=0;i<Len;i++)
		{
			Sum += arr[i];
		}
		Console.WriteLine($"Average of Values is: {Sum/Len}");
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray = new int[5]{3,15,99,0,4};
		PrintAverage(EmptyTestArray);
		PrintAverage(TestArray);
	}

}