// given a string which only contains a 0,1, or ? return an array 
// with every possibly combination of 0's and 1's only in place of ?
// ex. given '0?1' return ['001', '011']

using System;
using System.Collections.Generic;

public class Program
{

	public static List<string> BinaryStringExpansion(string str, List<string> result=null)
	{
		if(result == null)
		{
			result = new List<string>();
		}
		string[] Subs = str.Split(new[]{'?'},2);
		string First = Subs[0];
		if(First.Length == str.Length)
		{
			result.Add(str);
		}
		else
		{
			string Second = Subs[1]; // can't do this until we check if the str was actually split, otherwise we would get an index out of range error
			BinaryStringExpansion(First + 0 + Second, result);
			BinaryStringExpansion(First + 1 + Second, result);
		}
		return result;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(ArrayToString(BinaryStringExpansion("0?1")));
		Console.WriteLine(ArrayToString(BinaryStringExpansion("01??")));
		Console.WriteLine(ArrayToString(BinaryStringExpansion("???")));
		Console.WriteLine(ArrayToString(BinaryStringExpansion("01")));
	}

	public static string ArrayToString(List<string> arr)
	{
		return "[" + string.Join(",",arr) + "]";
	}

}