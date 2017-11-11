namespace SLL
{

	public static class SLLExtensionMethodSecondLargest
	{

		public static int? SecondLargest(this SinglyLinkedList linkedlist)
		{
			if(linkedlist.Head == null || linkedlist.Head.Next == null)
			{
				return null;
			}

			Node Current = linkedlist.Head;
			int LargestValue;
			int SecondLargestValue;

			if(Current.Value > Current.Next.Value)
			{
				LargestValue = Current.Value;
				SecondLargestValue = Current.Next.Value;
			}
			else
			{
				LargestValue = Current.Next.Value;
				SecondLargestValue = Current.Value;
			}

			Current = Current.Next.Next;

			while(Current != null)
			{
				if(Current.Value > LargestValue)
				{
					SecondLargestValue = LargestValue;
					LargestValue = Current.Value;
				}
				else if(Current.Value > SecondLargestValue)
				{
					SecondLargestValue = Current.Value;
				}

				Current = Current.Next;
			}

			return SecondLargestValue;

		}

	}

}