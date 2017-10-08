namespace SLL
{

	public static class SLLExtensionMethodIsEmpty
	{
		public static bool IsEmpty(this SinglyLinkedList linkedlist)
		{
			return linkedlist.Head == null ? true : false;
		}
	}

}