namespace SLL
{

	public static class SLLExtensionMethodSecondToLastValue
	{
		public static int? SecondToLastValue(this SinglyLinkedList linkedlist)
		{
			Node Current = linkedlist.Head;
			if(Current == null || Current.Next == null)
			{
				return null;
			}
			while(Current.Next.Next != null)
			{
				Current = Current.Next;
			}
			return Current.Value;
		}
	}

}