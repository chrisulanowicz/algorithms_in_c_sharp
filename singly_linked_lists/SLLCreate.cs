// Create a singly linked list using user input for each value
using System;

namespace SLL
{

	public static class SLLExtensionMethodCreate
	{
		public static SinglyLinkedList Create(this SinglyLinkedList linkedlist)
		{
			linkedlist = new SinglyLinkedList();
			string UserInput = "";
			while(UserInput != "Exit")
			{
				Console.WriteLine("Please input an integer value to add to your new singly linked list.");
				Console.WriteLine("Enter 'Exit' to finish and display your new list");
				UserInput = Console.ReadLine();
				if(UserInput != "Exit")
				{
					try
					{
						int NewValue = Int32.Parse(UserInput);
						linkedlist.AddBack(NewValue);
					}
					catch(Exception ex)
					{
						Console.WriteLine(ex.Message);
						Console.WriteLine("Value must either be a valid integer or 'Exit'!");
					}
				}
			}
			Console.WriteLine("Here is your final list:");
			Console.WriteLine(linkedlist.Display());
			return linkedlist;
		}
	}

}