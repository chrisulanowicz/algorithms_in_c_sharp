namespace SLL
{

	public static class SLLExtensionMethodSplitOnValue
	{
		public static SinglyLinkedList SplitOnValue(this SinglyLinkedList linkedlist, int val)
		{
			SinglyLinkedList SplitList = new SinglyLinkedList();
			Node Current = linkedlist.Head;
			if(Current != null && Current.Value == val)
			{
				SplitList.Head = Current;
				linkedlist.Head = null;
			}
			else if(Current != null)
			{
				while(Current.Next != null)
				{
					if(Current.Next.Value == val)
					{
						SplitList.Head = Current.Next;
						Current.Next = null;
						break;
					}
					Current = Current.Next;
				}
			}
			return SplitList;
		}
	}

}