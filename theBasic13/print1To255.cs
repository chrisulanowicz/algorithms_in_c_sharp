using System;

public class Program
{
	// function that prints all numbers from 1 to 255
	public static void print1To255()
	{
		for(int i=1;i<256;i++)
		{
			Console.WriteLine(i);
		}
	}


	public static void Main(string[] args)
	{
		print1To255();
	}
}