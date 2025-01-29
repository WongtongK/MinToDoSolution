namespace MinToDo.Services
{
	public class ToDoService : IToDoService
	{
		private readonly IList<ToDoItem> _todoItems;
		public ToDoService()
		{
			_todoItems = new List<ToDoItem>
			{
				new ToDoItem("Det her er min ToDo liste")
			};
		}
		public void Add(ToDoItem item)
		{
			_todoItems.Add(item);
		}
		public void Remove(ToDoItem item)
		{
			_todoItems.Remove(item);
		}
		public IEnumerable<ToDoItem> GetAll()
		{
			return _todoItems.ToList();
		}
		public void Complete(ToDoItem item)
		{
			item.Completed = true;
		}
		public void Uncomplete(ToDoItem item)
		{
			item.Completed = false;
		}
	}
}
