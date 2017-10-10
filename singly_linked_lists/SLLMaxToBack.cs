namespace SLL
{

	public static class SLLExtensionMethodMaxToBack
	{
		public static SinglyLinkedList MaxToBack(this SinglyLinkedList linkedlist)
		{
			Node Current = linkedlist.Head;
			if(Current == null)
			{
				return linkedlist;
			}
			Node BeforeMax = null;
			Node Max = Current;
			while(Current.Next != null)
			{
				if(Current.Next.Value > Max.Value)
				{
					BeforeMax = Current;
					Max = Current.Next;
				}
				Current = Current.Next;
			}
			if(Max != Current)
			{
				if(BeforeMax == null)
				{
					linkedlist.Head = Max.Next;
				}
				else
				{
					BeforeMax.Next = Max.Next;
				}
				Current.Next = Max;
				Max.Next = null;
			}
			return linkedlist;
		}
	}

}