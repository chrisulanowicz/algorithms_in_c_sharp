using System;

namespace SLL
{

	public class Program
	{

		public static void Main(string[] args)
		{
			SinglyLinkedList TestSLL = new SinglyLinkedList();
			Console.WriteLine(TestSLL.SLLToString()); // Head->null
			Console.WriteLine(TestSLL.Front()); // null
			Console.WriteLine(TestSLL.Back()); // null
			Console.WriteLine(TestSLL.IsEmpty()); // False
			Console.WriteLine(TestSLL.Contains(5)); // false
			TestSLL.AddBack(5);
			Console.WriteLine(TestSLL.SLLToString()); // Head->5->null
			TestSLL.AddFront(8);
			Console.WriteLine(TestSLL.SLLToString()); // Head->8->5->null
			TestSLL.AppendValue(7,8);
			Console.WriteLine(TestSLL.SLLToString()); // Head->8->7->5->null
			TestSLL.PrependValue(6,5);
			Console.WriteLine(TestSLL.SLLToString()); // Head->8->7->6->5->null
			Console.WriteLine(TestSLL.Back()); // 5
			Console.WriteLine(TestSLL.Front()); // 8
			Console.WriteLine(TestSLL.Contains(5)); // true
			Console.WriteLine(TestSLL.Contains(2)); // false
			Console.WriteLine(TestSLL.IsEmpty()); // False
		}

	}

}