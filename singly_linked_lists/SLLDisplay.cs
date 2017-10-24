namespace SLL
{

	public static class SLLExtensionMethodDisplay
	{
		public static string Display(this SinglyLinkedList linkedlist)
		{
			string Result = "Head->";
			Node Current = linkedlist.Head;
			while(Current != null)
			{
				Result += Current.Value + "->";
				Current = Current.Next;
			}
			Result += "null";
			return Result;
		}
	}

}