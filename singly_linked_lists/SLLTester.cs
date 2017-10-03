using System;

namespace SLL
{

	public class Program
	{

		public static void Main(string[] args)
		{
			SinglyLinkedList TestSLL = new SinglyLinkedList();
			Console.WriteLine(TestSLL.SLLToString());
			TestSLL.AddBack(5);
			Console.WriteLine(TestSLL.SLLToString());
			TestSLL.AddFront(8);
			Console.WriteLine(TestSLL.SLLToString());
			TestSLL.AppendValue(7,8);
			Console.WriteLine(TestSLL.SLLToString());
		}

	}

}