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
			Console.WriteLine("\n***** AddBack Tests");
			TestSLL.AddBack(5);
			TestSLL.AddBack(2);
			TestSLL.AddBack(4);
			Console.WriteLine(TestSLL.SLLToString()); // Head->5->2->4->null

			// SLLAddFront tests
			Console.WriteLine("\n***** AddFront Tests");
			TestSLL = new SinglyLinkedList(); // reset list to empty
			TestSLL.AddFront(5);
			TestSLL.AddFront(2);
			TestSLL.AddFront(4);
			Console.WriteLine(TestSLL.SLLToString()); // Head->4->2->5->null

			// SLLAppendValue tests
			Console.WriteLine("\n***** AppendValue Tests");
			TestSLL = new SinglyLinkedList(); // reset list to empty
			TestSLL.AppendValue(4, 9);
			TestSLL.AppendValue(5, 4);
			TestSLL.AppendValue(2, 4);
			TestSLL.AppendValue(8, 4);
			Console.WriteLine(TestSLL.SLLToString()); // Head->4->8->2->5->null

			// SLLBack tests
			Console.WriteLine("\n***** Back Tests");
			Console.WriteLine(EmptyTestSLL.Back()); // null
			Console.WriteLine(TestSLL1.Back()); // 9
			Console.WriteLine(TestSLL2.Back()); // 5

			// SLLContains tests
			Console.WriteLine("\n***** Contains Tests");
			Console.WriteLine(EmptyTestSLL.Contains(4)); // False
			Console.WriteLine(TestSLL1.Contains(9)); // True
			Console.WriteLine(TestSLL2.Contains(6)); // True
			Console.WriteLine(TestSLL2.Contains(1)); // False

			// SLLCount tests
			Console.WriteLine("\n***** Count Tests");
			Console.WriteLine(EmptyTestSLL.Count()); // 0
			Console.WriteLine(TestSLL1.Count()); // 1
			Console.WriteLine(TestSLL2.Count()); // 4

			// SLLFront tests
			Console.WriteLine("\n***** Front Tests");
			Console.WriteLine(EmptyTestSLL.Back()); // null
			Console.WriteLine(TestSLL1.Back()); // 9
			Console.WriteLine(TestSLL2.Back()); // 5

			// SLLIsEmpty tests
			Console.WriteLine("\n***** IsEmpty Tests");
			Console.WriteLine(EmptyTestSLL.IsEmpty()); // True
			Console.WriteLine(TestSLL1.IsEmpty()); // False
			Console.WriteLine(TestSLL2.IsEmpty()); // False

			// SLLMaxToBack tests
			Console.WriteLine("\n***** MaxToBack Tests");
			Console.WriteLine(EmptyTestSLL.MaxToBack().SLLToString()); // Head->null
			Console.WriteLine(TestSLL.MaxToBack().SLLToString()); // Head->4->2->5->8->null
			Console.WriteLine(TestSLL1.MaxToBack().SLLToString()); // Head->9->null

			// SLLMinMaxAverage tests
			Console.WriteLine("\n***** MinMaxAverage Tests");
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
			Console.WriteLine("\n***** PrependValue Tests");
			TestSLL.PrependValue(1, 4);
			TestSLL.PrependValue(7, 9);
			TestSLL.PrependValue(6, 8);
			Console.WriteLine(TestSLL.SLLToString()); // Head->1->4->2->5->6->8->7->null
			EmptyTestSLL.PrependValue(3, 5);
			Console.WriteLine(EmptyTestSLL.SLLToString()); // Head->3->null
			EmptyTestSLL = new SinglyLinkedList(); // reset EmptyTestSLL

			// SLLRemoveBack tests
			Console.WriteLine("\n***** RemoveBack Tests");
			var RemovedEmpty = EmptyTestSLL.RemoveBack();
			Console.WriteLine(RemovedEmpty); // nothing
			var Removed1 = TestSLL.RemoveBack();
			Console.WriteLine(Removed1); // node
			Console.WriteLine(TestSLL.SLLToString()); // Head->1->4->2->5->6->8->null

			// SLLRemoveFront tests
			Console.WriteLine("\n***** RemoveFront Tests");
			var RemovedEmpty2 = EmptyTestSLL.RemoveFront();
			Console.WriteLine(RemovedEmpty2); // nothing
			var Removed2 = TestSLL.RemoveFront();
			Console.WriteLine(Removed2); // node
			Console.WriteLine(TestSLL.SLLToString()); // Head->4->2->5->6->8->null

			// SLLSplitOnValue tests
			Console.WriteLine("\n***** SplitOnValue Tests");
			SinglyLinkedList Split1 = EmptyTestSLL.SplitOnValue(4);
			Console.WriteLine(Split1.SLLToString()); // Head->null
			SinglyLinkedList Split2 = TestSLL.SplitOnValue(8);
			Console.WriteLine(TestSLL.SLLToString()); // Head->4->2->5->6->null
			Console.WriteLine(Split2.SLLToString()); // Head->8->null
			SinglyLinkedList Split3 = Split2.SplitOnValue(8);
			Console.WriteLine(Split2.SLLToString()); // Head->null
			Console.WriteLine(Split3.SLLToString()); // Head->8->null

			// SLLToArray tests
			Console.WriteLine("\n***** ToArray Tests");
			int[] Array1 = EmptyTestSLL.ToArray();
			foreach(int val in Array1)
			{
				Console.WriteLine(val);
			}
			int[] Array2 = TestSLL1.ToArray();
			foreach(int val in Array2)
			{
				Console.WriteLine(val);
			}
			int[] Array3 = TestSLL2.ToArray();
			foreach(int val in Array3)
			{
				Console.WriteLine(val);
			}
		}

	}

}