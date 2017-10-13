using System;

namespace SLL
{

	public class Program
	{

		public static void Main(string[] args)
		{
			SinglyLinkedList TestSLL = new SinglyLinkedList();
			Console.WriteLine(TestSLL.SLLToString()); // Head->null
			Console.WriteLine(TestSLL.Count()); // 0
			// Console.WriteLine(TestSLL.Front()); // null
			// Console.WriteLine(TestSLL.Back()); // null
			// Console.WriteLine(TestSLL.IsEmpty()); // True
			// Console.WriteLine(TestSLL.Contains(5)); // False
			var results1 = TestSLL.MinMaxAverage();
			foreach(var result in results1)
			{
				Console.WriteLine(result);
			}
			var Removed1 = TestSLL.RemoveBack();
			Console.WriteLine(Removed1); // null
			var RemovedFront1 = TestSLL.RemoveFront();
			Console.WriteLine(RemovedFront1);
			Console.WriteLine(TestSLL.SLLToString());  // Head->null
			TestSLL.AddBack(5);
			Console.WriteLine(TestSLL.SLLToString()); // Head->5->null
			TestSLL.AddFront(8);
			Console.WriteLine(TestSLL.SLLToString()); // Head->8->5->null
			TestSLL.AppendValue(7,8);
			Console.WriteLine(TestSLL.SLLToString()); // Head->8->7->5->null
			TestSLL.PrependValue(6,5);
			Console.WriteLine(TestSLL.SLLToString()); // Head->8->7->6->5->null
			// Console.WriteLine(TestSLL.Back()); // 5
			// Console.WriteLine(TestSLL.Front()); // 8
			// Console.WriteLine(TestSLL.Contains(5)); // True
			// Console.WriteLine(TestSLL.Contains(2)); // False
			// Console.WriteLine(TestSLL.IsEmpty()); // False
			Console.WriteLine(TestSLL.Count()); // 4
			Console.WriteLine(TestSLL.MaxToBack().SLLToString());
			var results = TestSLL.MinMaxAverage();
			foreach(var result in results)
			{
				Console.WriteLine(result);
			}
			var Removed = TestSLL.RemoveBack();
			Console.WriteLine(Removed.Value); // 8
			Console.WriteLine(TestSLL.SLLToString());  // Head->7->6->5->null
			var RemovedFront2 = TestSLL.RemoveFront();
			Console.WriteLine(RemovedFront2.Value); // 7
			Console.WriteLine(TestSLL.SLLToString()); // Head->6->5->null
		}

	}

}