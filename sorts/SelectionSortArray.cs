using System;

public class Program
{

	public static int[] SelectionSort(int[] arr)
	{

		int Len = arr.Length;
		int Min;
		int MinIndex;
		int Temp;
		for(int i=0;i<Len;i++)
		{
			Min = arr[i];
			MinIndex = i;
			for(int j=i+1;j<Len;j++)
			{
				if(arr[j] < Min)
				{
					Min = arr[j];
					MinIndex = j;
				}
			}
			if(MinIndex != i)
			{
				Temp = arr[i];
				arr[i] = arr[MinIndex];
				arr[MinIndex] = Temp;
			}
		}
		return arr;
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray = new int[]{5,3,8,1,3,6,9,7,2,4};
		Console.WriteLine(ArrayToString(SelectionSort(EmptyTestArray)));
		Console.WriteLine(ArrayToString(SelectionSort(TestArray)));
	}

	public static string ArrayToString(int[] arr)
	{
		return "[" + string.Join(",", arr) + "]";
	}

}