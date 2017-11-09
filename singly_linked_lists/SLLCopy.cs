namespace SLL
{

	public static class SLLExtensionMethodCopy
	{

		public static SinglyLinkedList Copy(this SinglyLinkedList linkedlist)
		{
			SinglyLinkedList CopiedList = new SinglyLinkedList();
			Node Current = linkedlist.Head;
			while(Current != null)
			{
				CopiedList.AddBack(Current.Value);
				Current = Current.Next;
			}
			return CopiedList;
		}

	}

}