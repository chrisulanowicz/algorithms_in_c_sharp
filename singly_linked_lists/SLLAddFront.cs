namespace SLL
{

	public static class SLLExtensionMethodAddFront
	{
		public static void AddFront(this SinglyLinkedList linkedlist, int val)
		{
			Node NewNode = new Node(val);
			Node Current = linkedlist.Head;
			// if(Current == null)
			// {
			// 	linkedlist.Head = NewNode;
			// }
			// else
			// {
				NewNode.Next = Current;
				linkedlist.Head = NewNode;
			// }
		}
	}

}