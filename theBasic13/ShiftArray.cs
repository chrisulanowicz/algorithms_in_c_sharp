// Given an array, move all values forward by one index, dropping the first and leaving a '0' value at the end.
// ex. [4,5,6,7] becomes [5,6,7,0]

using System;
using System.Collections.Generic;

public class Program
{

	public static int[] ShiftArray(int[] arr)
	{
		int Len = arr.Length;
		int i;
		if(Len == 0)
		{
			return arr;
		}
		for(i=0;i<Len-1;i++)
		{
			arr[i] = arr[i+1];
		}
		arr[i] = 0;
		return arr;
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray = new int[]{4,5,6,7};
		Console.WriteLine(ArrayToString(ShiftArray(EmptyTestArray)));
		Console.WriteLine(ArrayToString(ShiftArray(TestArray)));
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