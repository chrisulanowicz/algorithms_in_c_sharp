using System.Collections.Generic;

namespace SLL
{

	public static class SLLExtensionMethodDeDupe
	{
		public static void DeDupe(this SinglyLinkedList linkedlist)
		{
			if(linkedlist.Head == null || linkedlist.Head.Next == null)
			{
				return;
			}

			List<int> ListValues = new List<int>();
			Node Previous = linkedlist.Head;
			Node Current = Previous.Next;
			ListValues.Add(Previous.Value);
			while(Current != null)
			{
				if(ListValues.Contains(Current.Value))
				{
					Previous.Next = Current.Next;
					Current = Previous.Next;
				}
				else
				{
					ListValues.Add(Current.Value);
					Previous = Current;
					Current = Current.Next;
				}
			}

		}
	}

}