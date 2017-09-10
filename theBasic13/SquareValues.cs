// Square each value in a given array, returning that same array with changed values.
// ex. [4,5,6,7] returns [16,25,36,49]

using System;

public class Program
{

	public static int[] SquareValues(int[] arr)
	{
		int Len = arr.Length;
		for(int i=0;i<Len;i++)
		{
			arr[i] *= arr[i];
		}
		return arr;
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray = new int[]{4,5,6,7};
		Console.WriteLine(ArrayToString(SquareValues(EmptyTestArray)));
		Console.WriteLine(ArrayToString(SquareValues(TestArray)));
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