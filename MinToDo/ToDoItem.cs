namespace MinToDo
{
	public class ToDoItem
	{
		public ToDoItem() { }
		public ToDoItem(string text)
		{
			Text = text;
		}

		public string Text { get; set; } = string.Empty;
		public bool Completed { get; set; }
	}
}
