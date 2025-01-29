namespace MinToDo.Services
{
	public interface IToDoService
	{
		public void Add(ToDoItem item);
		public void Remove(ToDoItem item);
		public IEnumerable<ToDoItem> GetAll();
		public void Complete(ToDoItem item);
		public void Uncomplete(ToDoItem item);
	}
}
