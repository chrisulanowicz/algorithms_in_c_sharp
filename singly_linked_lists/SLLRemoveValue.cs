namespace SLL
{

	public static class SLLExtensionMethodRemoveValue
	{
		public static Node RemoveValue(this SinglyLinkedList linkedlist, int value)
		{
			Node Current = linkedlist.Head;
			Node Previous = null;
			while(Current != null && Current.Value != value)
			{
				Previous = Current;
				Current = Current.Next;
			}
			if(Current != null & Previous == null)
			{
				linkedlist.Head = Current.Next;
				Current.Next = null;
			}
			else if(Current != null)
			{
				Previous.Next = Current.Next;
				Current.Next = null;
			}
			return Current;
		}
	}

}