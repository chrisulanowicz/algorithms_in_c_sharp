namespace SLL
{

	public static class SLLExtensionMethodRemoveNegatives
	{
		public static void RemoveNegatives(this SinglyLinkedList linkedlist)
		{
			Node Previous = null;
			Node Current = linkedlist.Head;
			while(Current != null)
			{
				while(Current != null && Current.Value < 0)
				{
					Current = Current.Next;
				}
				if(Previous == null)
				{
					linkedlist.Head = Current;
				}
				else
				{
					Previous.Next = Current;
				}
				if(Current != null)
				{
					Previous = Current;
					Current = Current.Next;
				}
			}
		}
	}

}