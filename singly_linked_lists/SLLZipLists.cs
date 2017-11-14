// Provided two pointers to independent linked lists, 
// 'zip' the two lists together by alternating nodes.
// Start with the first list, and return the new combined list

namespace SLL
{

	public static class SLLExtensionMethodZipLists
	{

		public static SinglyLinkedList ZipLists(this SinglyLinkedList linkedlist, SinglyLinkedList secondList)
		{
			SinglyLinkedList ZippedList = new SinglyLinkedList();
			Node CurrentFirst = linkedlist.Head;
			Node CurrentSecond = secondList.Head;
			Node TempFirst;
			Node TempSecond;

			if(CurrentFirst == null && CurrentSecond == null)
			{
				ZippedList.Head = null; 
			}
			else if(CurrentFirst == null)
			{
				ZippedList.Head = CurrentSecond;
			}
			else if(CurrentSecond == null)
			{
				ZippedList.Head = CurrentFirst;
			}
			else
			{
				ZippedList.Head = CurrentFirst;
				while(CurrentFirst != null && CurrentSecond != null)
				{
					TempFirst = CurrentFirst.Next;
					TempSecond = CurrentSecond.Next;
					CurrentFirst.Next = CurrentSecond;
					if(TempFirst != null)
					{
						CurrentSecond.Next = TempFirst;
						
					}
					CurrentFirst = TempFirst;
					CurrentSecond = TempSecond;
				}
				// if(CurrentFirst == null && CurrentSecond != null)
				// {
				// 	CurrentFirst.Ne
				// }
				// if(CurrentSecond == null && CurrentFirst != null)
				// {
				// 	// Do nothing here
				// }
			}

			return ZippedList;

		}

	}

}