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

			// Lists to be used when manipulating SLL
			SinglyLinkedList TestSLL = new SinglyLinkedList();
			SinglyLinkedList TestSLLVar = new SinglyLinkedList();
			SinglyLinkedList TestSLLVar2 = new SinglyLinkedList();

			// SLLAddBack tests
			Console.WriteLine("\n***** AddBack Tests");
			TestSLL.AddBack(5);
			TestSLL.AddBack(2);
			TestSLL.AddBack(4);
			Console.WriteLine(TestSLL.Display()); // Head->5->2->4->null

			// SLLAddFront tests
			Console.WriteLine("\n***** AddFront Tests");
			TestSLL = new SinglyLinkedList(); // reset list to empty
			TestSLL.AddFront(5);
			TestSLL.AddFront(2);
			TestSLL.AddFront(4);
			Console.WriteLine(TestSLL.Display()); // Head->4->2->5->null

			// SLLAppendValue tests
			Console.WriteLine("\n***** AppendValue Tests");
			TestSLL = new SinglyLinkedList(); // reset list to empty
			TestSLL.AppendValue(4, 9);
			TestSLL.AppendValue(5, 4);
			TestSLL.AppendValue(2, 4);
			TestSLL.AppendValue(8, 4);
			Console.WriteLine(TestSLL.Display()); // Head->4->8->2->5->null

			// SLLBack tests
			Console.WriteLine("\n***** Back Tests");
			Console.WriteLine(EmptyTestSLL.Back()); // null
			Console.WriteLine(TestSLL1.Back()); // 9
			Console.WriteLine(TestSLL2.Back()); // 5

			// SLLConcat tests
			Console.WriteLine("\n***** Concat Tests");
			TestSLLVar.AddBack(2).AddBack(4).AddBack(6);
			TestSLLVar2.AddBack(8).AddBack(10).AddBack(12);
			Console.WriteLine("First List: {0}", TestSLLVar.Display()); // Head->2->4->6->null
			Console.WriteLine("Second List: {0}", TestSLLVar2.Display()); // Head->8->10->12->null
			TestSLLVar.Concat(TestSLLVar2);
			Console.WriteLine("New Concatted List: {0}", TestSLLVar.Display()); // Head->2->4->6->8->10->12->null
			Console.WriteLine("Second List: {0}", TestSLLVar2.Display()); // Head->null
			TestSLLVar = new SinglyLinkedList(); // clear out for later user


			// SLLContains tests
			Console.WriteLine("\n***** Contains Tests");
			Console.WriteLine(EmptyTestSLL.Contains(4)); // False
			Console.WriteLine(TestSLL1.Contains(9)); // True
			Console.WriteLine(TestSLL2.Contains(6)); // True
			Console.WriteLine(TestSLL2.Contains(1)); // False

			// SLLCopy tests
			Console.WriteLine("\n***** Copy Tests");
			SinglyLinkedList CopiedEmptyList = EmptyTestSLL.Copy();
			Console.WriteLine(CopiedEmptyList.Display()); // Head->null
			SinglyLinkedList CopiedSingleNodeList = TestSLL1.Copy();
			Console.WriteLine(CopiedSingleNodeList.Display()); // Head->9->null
			SinglyLinkedList CopiedLongerList = TestSLL2.Copy();
			Console.WriteLine(CopiedLongerList.Display()); // Head->8->7->6->5->null
			// to verify these are copies I'll modify the copied list and check against original
			CopiedLongerList.RemoveValue(6);
			Console.WriteLine(CopiedLongerList.Display()); // Head->8->7->5->null
			Console.WriteLine(TestSLL2.Display()); // Head->8->7->6->5->null

			// SLLCount tests
			Console.WriteLine("\n***** Count Tests");
			Console.WriteLine(EmptyTestSLL.Count()); // 0
			Console.WriteLine(TestSLL1.Count()); // 1
			Console.WriteLine(TestSLL2.Count()); // 4

			// SLLCreate tests
			Console.WriteLine("\n***** Create Tests");
			SinglyLinkedList UserCreatedList = new SinglyLinkedList().Create();
			Console.WriteLine(UserCreatedList.Display());

			// SLLFilterHighLow tests
			Console.WriteLine("\n***** Filter High/Low Tests");
			Console.WriteLine(EmptyTestSLL.FilterHighLow(3,9).Display()); // Head->null
			Console.WriteLine(TestSLL1.FilterHighLow(3,12).Display()); // Head->9->null
			Console.WriteLine(TestSLL2.FilterHighLow(3,10).Display()); // Head->8->7->6->5->null
			TestSLLVar.AddBack(2).AddBack(4).AddBack(6).AddBack(8);
			Console.WriteLine(TestSLLVar.FilterHighLow(3,7).Display()); // Head->4->6->null
			Console.WriteLine(TestSLLVar.FilterHighLow(4,2).Display()); // Head->null
			TestSLLVar2.AddBack(1).AddBack(3).AddBack(5).AddBack(7).AddBack(9);
			Console.WriteLine(TestSLLVar2.FilterHighLow(8,12).Display()); // Head->9->null
			Console.WriteLine(TestSLLVar2.FilterHighLow(4,6).Display()); // Head->null

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
			Console.WriteLine(EmptyTestSLL.MaxToBack().Display()); // Head->null
			Console.WriteLine(TestSLL.MaxToBack().Display()); // Head->4->2->5->8->null
			Console.WriteLine(TestSLL1.MaxToBack().Display()); // Head->9->null

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
			
			// SLLMinToFront tests
			Console.WriteLine("\n***** MinToFront Tests");
			EmptyTestSLL.MinToFront();
			Console.WriteLine(EmptyTestSLL.Display()); // Head->null
			TestSLL.MinToFront();
			Console.WriteLine(TestSLL.Display()); // Head->2->4->5->8->null
			TestSLL1.MinToFront();
			Console.WriteLine(TestSLL1.Display()); // Head->9->null

			// SLLPartition tests
			Console.WriteLine("\n***** Partition Tests");
			EmptyTestSLL.Partition(4);
			Console.WriteLine(EmptyTestSLL.Display()); // Head->null
			TestSLL1.Partition(9);
			Console.WriteLine(TestSLL1.Display()); // Head->9->null
			TestSLL1.Partition(23);
			Console.WriteLine(TestSLL1.Display()); // Head->9->null
			TestSLLVar.AddBack(12).AddBack(8).AddBack(4).AddBack(2).AddBack(6).AddBack(10);
			TestSLLVar.Partition(6);
			Console.WriteLine(TestSLLVar.Display()); // Head->2->4->6->12->8->10->null
			TestSLLVar2.AddBack(2).AddBack(4).AddBack(3).AddBack(1).AddBack(6);
			TestSLLVar2.Partition(4);
			Console.WriteLine(TestSLLVar2.Display()); // Head->1->3->2->4->6->null
			TestSLLVar2.AddFront(8);
			TestSLLVar2.AddFront(12); // Will look like this now: Head->12->8->1->3->2->4->6->null
			TestSLLVar2.Partition(4);
			Console.WriteLine(TestSLLVar2.Display()); // Head->2->3->1->4->12->8->6->null


			// SLLPrependValue tests
			Console.WriteLine("\n***** PrependValue Tests");
			TestSLL.PrependValue(1, 4);
			TestSLL.PrependValue(7, 9);
			TestSLL.PrependValue(6, 8);
			Console.WriteLine(TestSLL.Display()); // Head->2->1->4->5->6->8->7->null
			EmptyTestSLL.PrependValue(3, 5);
			Console.WriteLine(EmptyTestSLL.Display()); // Head->3->null
			EmptyTestSLL = new SinglyLinkedList(); // reset EmptyTestSLL

			// SLLRemoveBack tests
			Console.WriteLine("\n***** RemoveBack Tests");
			var RemovedEmpty = EmptyTestSLL.RemoveBack();
			Console.WriteLine(RemovedEmpty); // nothing
			var Removed1 = TestSLL.RemoveBack();
			Console.WriteLine(Removed1); // node
			Console.WriteLine(TestSLL.Display()); // Head->2->1->4->5->6->8->null

			// SLLRemoveFront tests
			Console.WriteLine("\n***** RemoveFront Tests");
			var RemovedEmpty2 = EmptyTestSLL.RemoveFront();
			Console.WriteLine(RemovedEmpty2); // nothing
			var Removed2 = TestSLL.RemoveFront();
			Console.WriteLine(Removed2); // node
			Console.WriteLine(TestSLL.Display()); // Head->1->4->5->6->8->null

			// SLLRemoveNegatives tests
			Console.WriteLine("\n***** RemoveNegatives Tests");
			EmptyTestSLL.RemoveNegatives();
			Console.WriteLine(EmptyTestSLL.Display()); // Head->null
			TestSLL.RemoveNegatives();
			Console.WriteLine(TestSLL.Display()); // Head->1->4->5->6->8->null
			SinglyLinkedList NegativeTestSLL = new SinglyLinkedList();
			NegativeTestSLL.AddBack(-3).AddBack(-5).AddBack(-8);
			SinglyLinkedList PartialFrontNegativesSLL = new SinglyLinkedList();
			PartialFrontNegativesSLL.AddBack(-2).AddBack(-5).AddBack(3).AddBack(8);
			SinglyLinkedList PartialMiddleNegativesSLL = new SinglyLinkedList();
			PartialMiddleNegativesSLL.AddBack(4).AddBack(5).AddBack(-2).AddBack(-4).AddBack(8).AddBack(9);
			SinglyLinkedList PartialBackNegativesSLL = new SinglyLinkedList();
			PartialBackNegativesSLL.AddBack(2).AddBack(4).AddBack(-6).AddBack(-8);
			SinglyLinkedList PartialMixedNegativesSLL = new SinglyLinkedList();
			PartialMixedNegativesSLL.AddBack(4).AddBack(-6).AddBack(8).AddBack(-9).AddBack(5);
			PartialFrontNegativesSLL.RemoveNegatives();
			PartialMiddleNegativesSLL.RemoveNegatives();
			PartialBackNegativesSLL.RemoveNegatives();
			PartialMixedNegativesSLL.RemoveNegatives();
			Console.WriteLine(PartialFrontNegativesSLL.Display()); // Head->3->8->null
			Console.WriteLine(PartialMiddleNegativesSLL.Display()); // Head->4->5->8->9->null
			Console.WriteLine(PartialBackNegativesSLL.Display()); // Head->2->4->null
			Console.WriteLine(PartialMixedNegativesSLL.Display()); // Head->4->8->5->null

			// SLLRemoveValue tests
			Console.WriteLine("\n***** RemoveValue Tests");
			var RemovedEmptyValue = EmptyTestSLL.RemoveValue(5);
			Console.WriteLine(RemovedEmptyValue);  // nothing
			var RemovedValueNotThere = TestSLL.RemoveValue(9);
			Console.WriteLine(RemovedValueNotThere); // nothing
			var RemovedValueMiddle = TestSLL.RemoveValue(5);
			Console.WriteLine(RemovedValueMiddle); // node object
			Console.WriteLine(TestSLL.Display()); // Head->1->4->6->8->null

			// SLLSecondLargest tests
			Console.WriteLine("\n***** SecondLargest Tests");
			Console.WriteLine(EmptyTestSLL.SecondLargest()); // null (nothing)
			Console.WriteLine(TestSLL1.SecondLargest()); // null (nothing)
			Console.WriteLine(TestSLL2.SecondLargest()); // 7
			Console.WriteLine(TestSLL.SecondLargest()); // 6
			Console.WriteLine(TestSLLVar.SecondLargest()); // 10
			Console.WriteLine(TestSLLVar2.SecondLargest()); // 8

			// SLLSecondToLastValue tests
			Console.WriteLine("\n***** SecondToLastValue Tests");
			Console.WriteLine(EmptyTestSLL.SecondToLastValue()); // null
			Console.WriteLine(TestSLL1.SecondToLastValue()); // null
			Console.WriteLine(TestSLL2.SecondToLastValue()); // 6
			Console.WriteLine(TestSLL.SecondToLastValue()); // 6

			// SLLSplitOnValue tests
			Console.WriteLine("\n***** SplitOnValue Tests");
			SinglyLinkedList Split1 = EmptyTestSLL.SplitOnValue(4);
			Console.WriteLine(Split1.Display()); // Head->null
			SinglyLinkedList Split2 = TestSLL.SplitOnValue(8);
			Console.WriteLine(TestSLL.Display()); // Head->1->4->6->null
			Console.WriteLine(Split2.Display()); // Head->8->null
			SinglyLinkedList Split3 = Split2.SplitOnValue(8);
			Console.WriteLine(Split2.Display()); // Head->null
			Console.WriteLine(Split3.Display()); // Head->8->null

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