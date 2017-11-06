using System;

namespace SLL
{

	public class Program
	{
		public static void TowerOfHanoi(int numRings, string origin, string destination, string spare)
		{
			if(numRings < 1)
			{
				return;
			}
			else if(numRings == 1)
			{
				Console.WriteLine("Move a ring from {0} to {1}", origin, destination);
				return;
			}
			else
			{
				TowerOfHanoi(numRings-1, origin, spare, destination);
				TowerOfHanoi(1, origin, destination, spare);
				TowerOfHanoi(numRings-1, spare, destination, origin);
			}
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Tower with only 1 ring");
			TowerOfHanoi(1, "origin", "destination", "spare");

			Console.WriteLine("Tower with 2 rings");
			TowerOfHanoi(2, "origin", "destination", "spare");

			Console.WriteLine("Tower with 4 rings");
			TowerOfHanoi(4, "origin", "destination", "spare");
		}
	}

}