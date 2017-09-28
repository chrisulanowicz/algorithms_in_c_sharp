using System;

namespace SLL
{

	public class Program
	{

		public static void Main(string[] args)
		{
			SinglyLinkedList TestSLL = new SinglyLinkedList();
			Console.WriteLine(TestSLL);
			Console.WriteLine("****************");
			Console.WriteLine(TestSLL.Head);
			if(TestSLL.Head == null)
			{
				Console.WriteLine("Head is NULL!!!!!!!!!!!!!!!!!!!");
			}
			TestSLL.AddBack(5);
			Console.WriteLine(TestSLL);
			Console.WriteLine(TestSLL.Head);
			Console.WriteLine(TestSLL.Head.Value);
			Console.WriteLine(TestSLL.Head.Next);
		}

	}

}