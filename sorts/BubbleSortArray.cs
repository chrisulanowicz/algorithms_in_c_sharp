using System;

public class Program
{

	public static int[] BubbleSort(int[] arr)
	{
		int Len = arr.Length;
		int temp;
		for(int i=Len-1;i>0;i--)
		{
			for(int j=0;j<i;j++)
			{
				if(arr[j] > arr[j+1])
				{
					temp = arr[j];
					arr[j] = arr[j+1];
					arr[j+1] = temp;
				}
			}
		}
		return arr;
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray = new int[]{5,3,6,8,2,4,6,1,9,3};
		int[] Sorted1 = BubbleSort(TestArray);
		Console.WriteLine(ArrayToString(BubbleSort(EmptyTestArray)));
		Console.WriteLine(ArrayToString(Sorted1));
	}

	public static string ArrayToString(int[] arr)
		{
			return "[" + string.Join(",",arr) + "]";
		}

}