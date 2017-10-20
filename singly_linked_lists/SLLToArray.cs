namespace SLL
{

	public static class SLLExtensionMethodToArray
	{
		public static int[] ToArray(this SinglyLinkedList linkedlist)
		{
			int count = linkedlist.Count();
			int[] ListArray = new int[count];
			Node Current = linkedlist.Head;
			for(int i=0;i<count;i++)
			{
				ListArray[i] = Current.Value;
				Current = Current.Next;
			}
			return ListArray;
		}
	}

}