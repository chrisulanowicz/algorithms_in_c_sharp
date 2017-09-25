// given a sorted array and a value, see if the array contains that value using binary search

using System;

public class Program
{

	public static bool BinarySearch(int[] arr, int val, int start=0, int end=-1)
	{
		if(end == -1)
		{
			end = arr.Length;
		}
		if(start >= end || val < arr[start] || val > arr[end-1])
		{
			return false;
		}
		int Mid = (start + end)/2;
		if(arr[Mid] == val)
		{
			return true;
		}
		else if(val < arr[Mid])
		{
			end = Mid;
		}
		else 
		{
			start = Mid+1;
		}
		return BinarySearch(arr,val,start,end);
	}

	public static void Main(string[] args)
	{
		int[] TestArray = new int[]{2,4,6,8,10};
		Console.WriteLine(BinarySearch(TestArray, 6));
		Console.WriteLine(BinarySearch(TestArray, 2));
		Console.WriteLine(BinarySearch(TestArray, 10));
		Console.WriteLine(BinarySearch(TestArray, 7));
		Console.WriteLine(BinarySearch(TestArray, 1));
		Console.WriteLine(BinarySearch(TestArray, 22));
	}
}