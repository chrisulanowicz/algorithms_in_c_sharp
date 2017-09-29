namespace SLL
{

	public static class SLLExtensionMethodAddBack
	{

		public static void AddBack(this SinglyLinkedList linkedList, int val)
		{
			Node NewNode = new Node(val);
			Node Current = linkedList.Head;
			if(Current == null)
			{
				linkedList.Head = NewNode;
			}
			else
			{
				while(Current.Next != null)
				{
					Current = Current.Next;
				}
				Current.Next = NewNode;
			}
		}

	}

}