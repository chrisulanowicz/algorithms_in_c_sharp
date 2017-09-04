// Given an array, print the max, min, and average values for that array.
// ex. for [3,15,99,0,4] the max is 99, the min is 0, and the average is 24.2

using System;

public class Program
{

	public static void MinMaxAverage(int[] arr)
	{
		int Len = arr.Length;

		if(Len == 0)
		{	
			Console.WriteLine("Array is empty");
			return;
		}

		double Sum = arr[0];
		int Max = arr[0];
		int Min = arr[0];
		for(int i=1;i<Len;i++)
		{
			if(arr[i] > Max)
			{
				Max = arr[i];
			}
			if(arr[i] < Min)
			{
				Min = arr[i];
			}
			Sum += arr[i];
		}
		Console.WriteLine($"Min value is: {Min}, Max value is: {Max}, and Average of values is: {Sum/Len}");
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray = new int[5]{3,15,99,0,4};
		MinMaxAverage(EmptyTestArray);
		MinMaxAverage(TestArray);
	}

}