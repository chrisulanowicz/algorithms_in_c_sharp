// Create an array with all the odd integer between 1 and 255 (inclusive).
// extra: allow function to take in a parameter that sets upper limit instead of hardcoding 255
// double extra: also give it another parameter to set the lower limit/start

using System;
using System.Collections.Generic;

public class Program
{

	public static List<int> OddArray(int start, int limit)
	{
		List<int> Odds = new List<int>();
		int OddStart = start%2==0 ? start+1 : start;
		for(int i=OddStart;i<limit;i+=2)
		{
			Odds.Add(i);
		}
		return Odds;
	}

	public static void Main(string[] args)
	{
		List<int> MyOdds = OddArray(8,15);
		MyOdds.ForEach(Console.WriteLine);

		List<int> MyOdds2 = OddArray(1,256);
		Console.WriteLine(ListToString(MyOdds2));


	}

	// Helper function to convert List into one string that represents the data structure with values
	public static string ListToString(List<int> list)
	{
		string result = "[";
		int Len = list.Count;
		for(int i=0;i<Len;i++)
		{
			result += list[i].ToString();
			result += ", ";
		}
		result += "]";
		return result;
	}

}