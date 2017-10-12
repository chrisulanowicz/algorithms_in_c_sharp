// function that removes and returns the node at the back (end) of the list

namespace SLL
{

	public static class SLLExtensionMethodRemoveBack
	{
		public static Node RemoveBack(this SinglyLinkedList linkedlist)
		{
			Node Current = linkedlist.Head;
			Node Previous = null;
			if(Current == null || Current.Next == null)
			{
				linkedlist.Head = null;
			}
			else
			{
				while(Current.Next != null)
				{
					Previous = Current;
					Current = Current.Next;
				}
				Previous.Next = null;
			}
			return Current;
		}
	}

}