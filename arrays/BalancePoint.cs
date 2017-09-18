// given an array of integers, determine if it has a balance point between indices
// where the sum of values on either side are equal
// ex. [1,2,3,4,10] returns true (1+2+3+4 =10 / 10)
// ex. [1,2,8] returns false

using System;


public class Program
{

	public static bool HasBalancePoint(int[] arr)
	{
		int Len = arr.Length;

		if(Len == 0)
		{
			return false;
		}

		int SumLeft = 0;
		int SumRight = 0;

		for(int i=0;i<Len;i++)
		{
			SumLeft += arr[i];
			SumRight = 0;
			for(int j=i+1;j<Len;j++)
			{
				SumRight += arr[j];
			}
			if(SumLeft == SumRight)
			{
				return true;
			}
		}

		return false;
	}

	public static void Main(string[] args)
	{
		int[] EmptyTestArray = new int[0];
		int[] TestArray1 = new int[]{1,2,3,4,10};
		int[] TestArray2 = new int[]{1,2,8};
		int[] TestArray3 = new int[]{-4,20,3,5,8};
		int[] TestArray4 = new int[]{11,1,2,3,5};
		Console.WriteLine(HasBalancePoint(EmptyTestArray)); // => false
		Console.WriteLine(HasBalancePoint(TestArray1)); // => true
		Console.WriteLine(HasBalancePoint(TestArray2)); // => false
		Console.WriteLine(HasBalancePoint(TestArray3)); // => true
		Console.WriteLine(HasBalancePoint(TestArray4)); // => true
	}

}