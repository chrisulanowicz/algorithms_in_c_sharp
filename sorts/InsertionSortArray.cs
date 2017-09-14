using System;

public class Program
{

	public static int[] InsertionSort(int[] arr)
	{
		int Len = arr.Length;
		int Temp;
		int j;
		for(int i=1;i<Len;i++)
		{
			Temp = arr[i];
			j = i-1;
			while(j>=0 && Temp < arr[j])
			{
				arr[j+1] = arr[j];
				j--;
			}
			arr[j+1] = Temp;
		}
		return arr;
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray = new int[]{5,4,7,8,2,7,3,1,9,6};
		Console.WriteLine(ArrayToString(InsertionSort(EmptyTestArray)));
		Console.WriteLine(ArrayToString(InsertionSort(TestArray)));
	}

	public static string ArrayToString(int[] arr)
	{
		return "[" + string.Join(",",arr) + "]";
	}

}