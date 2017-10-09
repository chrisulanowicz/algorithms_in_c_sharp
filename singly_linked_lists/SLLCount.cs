// return the number of nodes in a list

namespace SLL
{

	public static class SLLExtensionMethodCount
	{
		public static int Count(this SinglyLinkedList linkedlist)
		{
			int counter = 0;
			Node Current = linkedlist.Head;
			while(Current != null)
			{
				counter++;
				Current = Current.Next;
			}
			return counter;
		}
	}

}