namespace SLL
{

	public static class SLLExtensionMethodConcat
	{
		public static SinglyLinkedList Concat(this SinglyLinkedList linkedlist, SinglyLinkedList listToConcat)
		{
			Node Current = linkedlist.Head;
			if(Current == null)
			{
				linkedlist.Head = listToConcat.Head;
			}
			else
			{
				while(Current.Next != null)
				{
					Current = Current.Next;
				}
				Current.Next = listToConcat.Head;
			}
			listToConcat.Head = null;
			return linkedlist;
		}
	}

}