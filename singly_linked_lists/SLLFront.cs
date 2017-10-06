// function that returns the value of the node at the front (head) of the list

namespace SLL
{

	public static class SLLExtensionMethodFront
	{
		public static string Front(this SinglyLinkedList linkedlist)
		{
			return linkedlist.Head == null ? "null" : linkedlist.Head.Value.ToString();
		}
	}

}


// if you need to return an 'int' datatype instead of a string
//	change return type to int? since it can return null in some cases
//  change return statement to 
//		return linkedlist.Head == null ? (int?)null : Current.Value;