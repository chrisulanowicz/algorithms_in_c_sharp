namespace SLL
{

	public class Node
	{

		public int Value { get; set; }
		public Node Next { get; set; }

		public Node()
		{
			
		}

		public Node(int val)
		{
			Value = val;
			Next = null;
		}

	}

}