// Given a value, create a new node and assign it to the list Head

namespace SLL
{

	public static class SLLExtensionMethodAddFront
	{
		public static void AddFront(this SinglyLinkedList linkedlist, int val)
		{
			Node NewNode = new Node(val);
			Node Current = linkedlist.Head;
				NewNode.Next = Current;
				linkedlist.Head = NewNode;
		}
	}

}