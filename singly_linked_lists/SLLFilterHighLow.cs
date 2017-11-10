namespace SLL
{

	public static class SLLExtensionMethodFilterHL
	{

		public static SinglyLinkedList FilterHighLow(this SinglyLinkedList linkedlist, int lowValue, int highValue)
		{
			Node Current = linkedlist.Head;
			if(lowValue > highValue)
			{
				linkedlist.Head = null;
				return linkedlist;
			}
			while(Current != null && Current.Value < lowValue || Current != null && Current.Value > highValue)
			{
				linkedlist.Head = Current.Next;
				Current.Next = null;
				Current = linkedlist.Head;
			}
			while(Current != null && Current.Next != null)
			{
				if(Current.Next.Value < lowValue || Current.Next.Value > highValue)
				{
					Current.Next = Current.Next.Next;
				}
				else
				{
					Current = Current.Next;
				}
			}
			return linkedlist;
		}

	}

}