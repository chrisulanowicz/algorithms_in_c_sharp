namespace SLL
{

	public static class NodeExtensionMethodRemoveSelf
	{
		public static void RemoveSelf(this Node currentNode)
		{
			if(currentNode.Next == null)
			{
				return;
			}
			currentNode.Value = currentNode.Next.Value;
			currentNode.Next = currentNode.Next.Next;
		}
	}

}