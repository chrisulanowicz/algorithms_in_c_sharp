// Iterate through a given array, printing each value.

using System;

public class Program
{

	public static void IterateArray(int[] arr)
	{
		int Len = arr.Length;
		for(int i=0;i<Len;i++)
		{
			Console.WriteLine(arr[i]);
		}
	}

	public static void Main(string[] args)
	{
		int[] TestArray = new int[5]{4,2,6,8,1};
		int[] EmptyTestArray = new int[0];
		IterateArray(TestArray);
		IterateArray(EmptyTestArray);
	}

}