namespace SLL
{

	public static class SLLExtensionMethodContains
	{
		public static bool Contains(this SinglyLinkedList linkedlist, int val)
		{
			Node Current = linkedlist.Head;
			while(Current != null)
			{
				if(Current.Value == val)
				{
					return true;
				}
				Current = Current.Next;
			}
			return false;
		}
	}

}