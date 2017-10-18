using System;

namespace SLL
{

	public class Program
	{

		public static void Main(string[] args)
		{
			// Test Lists
			// Empty List
			SinglyLinkedList EmptyTestSLL = new SinglyLinkedList();

			// List with only One Node
			SinglyLinkedList TestSLL1 = new SinglyLinkedList();
			TestSLL1.AddBack(9);

			// List with several Nodes
			SinglyLinkedList TestSLL2 = new SinglyLinkedList();
			TestSLL2.AddBack(8);
			TestSLL2.AddBack(7);
			TestSLL2.AddBack(6);
			TestSLL2.AddBack(5);

			// List to be used when manipulating SLL
			SinglyLinkedList TestSLL = new SinglyLinkedList();

			// SLLAddBack tests
			TestSLL.AddBack(5);
			TestSLL.AddBack(2);
			TestSLL.AddBack(4);
			Console.WriteLine(TestSLL.SLLToString()); // Head->5->2->4->null

			// SLLAddFront tests
			TestSLL = new SinglyLinkedList(); // reset list to empty
			TestSLL.AddFront(5);
			TestSLL.AddFront(2);
			TestSLL.AddFront(4);
			Console.WriteLine(TestSLL.SLLToString()); // Head->4->2->5->null

			// SLLAppendValue tests
			TestSLL = new SinglyLinkedList(); // reset list to empty
			TestSLL.AppendValue(4, 9);
			TestSLL.AppendValue(5, 4);
			TestSLL.AppendValue(2, 4);
			TestSLL.AppendValue(8, 4);
			Console.WriteLine(TestSLL.SLLToString()); // Head->4->8->2->5->null

			// SLLBack tests
			Console.WriteLine(EmptyTestSLL.Back()); // null
			Console.WriteLine(TestSLL1.Back()); // 9
			Console.WriteLine(TestSLL2.Back()); // 5

			// SLLContains tests
			Console.WriteLine(EmptyTestSLL.Contains(4)); // False
			Console.WriteLine(TestSLL1.Contains(9)); // True
			Console.WriteLine(TestSLL2.Contains(6)); // True
			Console.WriteLine(TestSLL2.Contains(1)); // False

			// SLLCount tests
			Console.WriteLine(EmptyTestSLL.Count()); // 0
			Console.WriteLine(TestSLL1.Count()); // 1
			Console.WriteLine(TestSLL2.Count()); // 4

			// SLLFront tests
			Console.WriteLine(EmptyTestSLL.Back()); // null
			Console.WriteLine(TestSLL1.Back()); // 9
			Console.WriteLine(TestSLL2.Back()); // 5

			// SLLIsEmpty tests
			Console.WriteLine(EmptyTestSLL.IsEmpty()); // True
			Console.WriteLine(TestSLL1.IsEmpty()); // False
			Console.WriteLine(TestSLL2.IsEmpty()); // False

			// SLLMaxToBack tests
			Console.WriteLine(EmptyTestSLL.MaxToBack().SLLToString()); // Head->null
			Console.WriteLine(TestSLL.MaxToBack().SLLToString()); // Head->4->2->5->8->null
			Console.WriteLine(TestSLL1.MaxToBack().SLLToString()); // Head->9->null

			// SLLMinMaxAverage tests
			var resultsEmpty = EmptyTestSLL.MinMaxAverage();
			foreach(var result in resultsEmpty)
			{
				Console.WriteLine(result);
			}
			var results1 = TestSLL.MinMaxAverage();
			foreach(var result in results1)
			{
				Console.WriteLine(result);
			}
			
			// SLLPrependValue tests
			TestSLL.PrependValue(1, 4);
			TestSLL.PrependValue(7, 9);
			TestSLL.PrependValue(6, 8);
			Console.WriteLine(TestSLL.SLLToString()); // Head->1->4->2->5->6->8->7->null
			EmptyTestSLL.PrependValue(3, 5);
			Console.WriteLine(EmptyTestSLL.SLLToString()); // Head->3->null
			EmptyTestSLL = new SinglyLinkedList(); // reset EmptyTestSLL

			// SLLRemoveBack tests
			var RemovedEmpty = EmptyTestSLL.RemoveBack();
			Console.WriteLine(RemovedEmpty); // nothing
			var Removed1 = TestSLL.RemoveBack();
			Console.WriteLine(Removed1); // node
			Console.WriteLine(TestSLL.SLLToString()); // Head->1->4->2->5->6->8->null

			// SLLRemoveFront tests
			var RemovedEmpty2 = EmptyTestSLL.RemoveFront();
			Console.WriteLine(RemovedEmpty2); // nothing
			var Removed2 = TestSLL.RemoveFront();
			Console.WriteLine(Removed2); // node
			Console.WriteLine(TestSLL.SLLToString()); // Head->4->2->5->6->8->null

		}

	}

}