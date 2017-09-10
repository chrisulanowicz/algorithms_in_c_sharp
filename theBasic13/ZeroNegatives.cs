// Return the given array, after setting any negative values to zero.
// ex. [4,5,-6,7] returns [4,5,0,7]

using System;
using System.Collections.Generic;

public class Program
{

	public static int[] SwapNegatives(int[] arr)
	{
		int Len = arr.Length;
		for(int i=0;i<Len;i++)
		{
			if(arr[i] < 0)
			{
				arr[i] = 0;
			}
		}
		return arr;
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray = new int[]{4,5,-6,7};
		Console.WriteLine(ArrayToString(SwapNegatives(EmptyTestArray)));
		Console.WriteLine(ArrayToString(SwapNegatives(TestArray)));
	}

	// Helper function to convert List into one string that represents the data structure with values
	public static string ArrayToString(int[] list)
	{
		string result = "[";
		int Len = list.Length;
		for(int i=0;i<Len;i++)
		{
			result += list[i].ToString();
			result += ",";
		}
		result += "]";
		return result;
	}

}