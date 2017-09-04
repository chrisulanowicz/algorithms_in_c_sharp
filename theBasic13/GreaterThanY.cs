// Given an array and a value Y, count and print the number of array values greater than Y.
// ex. arr=[1, 3, 5] and Y=2 should count 2

using System;

public class Program
{

	public static void GreaterThanY(int[] arr, int y)
	{
		int count = 0;
		int Len = arr.Length;
		for(int i=0;i<Len;i++)
		{
			if(arr[i] > Len)
			{
				count++;
			}
		}
		Console.WriteLine($"There are {count} values greater than {y}");
	}

	public static void Main(string[] args)
	{
		int[] TestArray = new int[5]{4,2,6,8,1};
		int[] EmptyTestArray = new int[0];
		GreaterThanY(TestArray, 5);
		GreaterThanY(EmptyTestArray, 2);
	}

}