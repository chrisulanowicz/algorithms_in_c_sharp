// function that inserts a new node immediately after an existing node with a given value
// if that value doesn't exist inside the list then just insert the new node at the end of the list

namespace SLL
{

	public static class SLLExtensionMethodAppendValue
	{

		public static void AppendValue(this SinglyLinkedList linkedlist, int val, int after)
		{
			Node NewNode = new Node(val);
			Node Current = linkedlist.Head;
			if(Current == null)
			{
				linkedlist.Head = NewNode;
			}
			while(Current.Next != null && Current.Value != after)
			{
				Current = Current.Next;
			}
			NewNode.Next = Current.Next;
			Current.Next = NewNode;
		}

	}

}