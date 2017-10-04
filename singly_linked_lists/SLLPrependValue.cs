namespace SLL
{

	public static class SLLExtensionMethodPrependValue
	{
		public static void PrependValue(this SinglyLinkedList linkedlist, int val, int before)
		{
			Node NewNode = new Node(val);
			Node Current = linkedlist.Head;
			if(Current == null || Current.Value == before)
			{
				NewNode.Next = Current;
				linkedlist.Head = NewNode;
				return;
			}
			while(Current.Next != null && Current.Next.Value != before)
			{
				Current = Current.Next;
			}
			NewNode.Next = Current.Next;
			Current.Next = NewNode;
		}
	}

}