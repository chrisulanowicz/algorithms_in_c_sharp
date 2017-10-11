// function that finds the min, max and average of values in a list and returns an object with those results

using System.Collections.Generic;

namespace SLL
{

	public static class SLLExtensionMethodMinMaxAverage
	{
		public static Dictionary<string, double> MinMaxAverage(this SinglyLinkedList linkedlist)
		{
			Node Current = linkedlist.Head;
			Dictionary<string, double> result = new Dictionary<string, double>();
			if(Current == null)
			{
				result.Add("average", -1);
			}
			else
			{
				double Max = Current.Value;
				double Min = Current.Value;
				double Sum = 0.0;
				int Counter = 0;
				while(Current != null)
				{
					if(Current.Value > Max)
					{
						Max = Current.Value;
					}
					if(Current.Value < Min)
					{
						Min = Current.Value;
					}
					Sum += Current.Value;
					Counter++;
					Current = Current.Next;
				}
				result.Add("Min", Min);
				result.Add("Max", Max);
				result.Add("Avg", Sum/Counter);
			}
			return result;
		}
	}

}