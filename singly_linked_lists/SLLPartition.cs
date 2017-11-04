// given a value, move all lesser to left and greater to right of the value 
// original order need not be preserved

namespace SLL
{

	public static class SLLExtensionMethodPartition
	{
		// method done so that you only need to iterate through the list once
		// but this looks ugly, could use some refactoring
		// other option is to iterate through the list to find the partition 
		// and then iterate through a second time moving nodes to their proper sides

		public static void Partition(this SinglyLinkedList linkedlist, int val)
		{
			Node Current = linkedlist.Head;
			Node Previous = null;
			Node PriorToPartition = null;
			Node Partition = null;
			Node TempPartition = null;

			while(Current != null)
			{
				if(Current.Value == val && Partition == null)
				{
					Partition = Current;
					if(TempPartition == null)
					{
						Previous = Current;
						Current = Current.Next;
					}
					else if(TempPartition != null && PriorToPartition == null)
					{
						Previous.Next = Current.Next;
						Current = Current.Next;
						linkedlist.Head = Partition;
						Partition.Next = TempPartition;
					}
					else if(TempPartition != null)
					{
						Previous.Next = Current.Next;
						Current = Current.Next;
						PriorToPartition.Next = Partition;
						Partition.Next = TempPartition;
					}
				}
				else if(Current.Value > val && Partition == null && TempPartition == null)
				{
					TempPartition = Current;
					Previous = Current;
					Current = Current.Next;
				}
				else if(Current.Value < val && Partition != null || Current.Value < val && TempPartition != null)
				{
					Previous.Next = Current.Next;
					Current.Next = linkedlist.Head;
					linkedlist.Head = Current;
					Current = Previous.Next;
					if(PriorToPartition == null)
					{
						PriorToPartition = linkedlist.Head; 
					}
				}
				else if(Partition == null && TempPartition == null)
				{
					PriorToPartition = Current;
					Previous = Current;
					Current = Current.Next;
				}
				else
				{
					Previous = Current;
					Current = Current.Next;
				}
			}
		}
	}

}