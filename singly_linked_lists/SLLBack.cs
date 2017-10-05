// function that returns the value of the node at the back (end) of the list

namespace SLL 
{

	public static class SLLExtensionMethodBack
	{
		public static string Back(this SinglyLinkedList linkedlist)
		{
			Node Current = linkedlist.Head;
			while(Current != null && Current.Next != null)
			{
				Current = Current.Next;
			}
			return Current == null ? "null" : Current.Value.ToString();
		}
	}

}

// if you need to return an 'int' datatype instead of a string
//	change return type to int? since it can return null in some cases
//  change return statement to 
//		return Current == null ? (int?)null : Current.Value;