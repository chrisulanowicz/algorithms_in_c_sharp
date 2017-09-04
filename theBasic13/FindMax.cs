using System;

public class Program
{

	public static void FindMax(int[] arr)
	{

		int Len = arr.Length;
		if(Len == 0)
		{
			Console.WriteLine("Array is empty");
			return;
		}
		int Max = arr[0];
		for(int i=1;i<Len;i++)
		{
			if(arr[i] > Max)
			{
				Max = arr[i];
			}
		}
		Console.WriteLine("Max value is: " + Max);
	}

	public static void Main(string[] args)
	{
		int[] TestArray = new int[5]{8,4,9,1,-5};
		int[] EmptyTestArray = new int[0];
		FindMax(TestArray);
		FindMax(EmptyTestArray);
	}

}