namespace SLL
{

	public static class SLLExtensionMethodRemoveFront
	{
		public static Node RemoveFront(this SinglyLinkedList linkedlist)
		{
			Node Current = linkedlist.Head;
			if(Current != null)
			{
				linkedlist.Head = Current.Next;
				Current.Next = null;
			}
			return Current;
		}
	}

}