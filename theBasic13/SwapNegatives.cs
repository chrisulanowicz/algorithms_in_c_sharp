// Given an array of numbers, replace any negative values with the string 'Dojo'.
// ex. [4,5,-6,7] returns [4,5,'Dojo',7]

using System;
using System.Collections.Generic;

public class Program
{

	public static List<object> SwapNegatives(int[] arr)
	{
		int Len = arr.Length;
		List<object> NoNegatives = new List<object>();
		for(int i=0;i<Len;i++)
		{
			if(arr[i] < 0)
			{
				NoNegatives.Add("Dojo");
			}
			else
			{
				NoNegatives.Add(arr[i]);
			}		}
		return NoNegatives;
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray = new int[]{4,5,-6,7};
		Console.WriteLine(ArrayToString(SwapNegatives(EmptyTestArray)));
		Console.WriteLine(ArrayToString(SwapNegatives(TestArray)));
	}

	// Helper function to convert List into one string that represents the data structure with values
	public static string ArrayToString(List<object> list)
	{
		string result = "[";
		int Len = list.Count;
		for(int i=0;i<Len;i++)
		{
			result += list[i].ToString();
			result += ",";
		}
		result += "]";
		return result;
	}

}