namespace SLL
{

	public class SinglyLinkedList
	{
		public Node Head { get; set; }

		public SinglyLinkedList()
		{
			Head = null;
		}

		public string SLLToString()
		{
			string Result = "Head->";
			Node Current = Head;
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