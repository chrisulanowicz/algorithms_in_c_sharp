namespace SLL
{

	public static class SLLExtensionMethodMinToFront
	{
		public static void MinToFront(this SinglyLinkedList linkedlist)
		{
			Node Previous = null;
			Node Min = null;
			Node Current = linkedlist.Head;
			if(Current != null)
			{
				Min = Current;
			}
			while(Current != null && Current.Next != null)
			{
				if(Current.Next.Value < Min.Value)
				{
					Previous = Current;
					Min = Current.Next;
				}
				Current = Current.Next;
			}
			if(Previous != null)
			{
				Previous.Next = Min.Next;
				Min.Next = linkedlist.Head;
				linkedlist.Head = Min;
			}
		}
	}

}