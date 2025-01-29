namespace MinToDo.Services
{
	public class ToDoService : IToDoService
	{
		private readonly IList<ToDoItem> _todoItems;
		public ToDoService()
		{
			_todoItems = new List<ToDoItem>
			{
				new ToDoItem("Lav en hjemmeside som portfolio, til når du skal søge praktik og arbejde"),
				new ToDoItem("Bliv færdig med Kaj Bromose LevSundt"),
				new ToDoItem("Tag eksamen for SCRUM Master"),
				new ToDoItem("Udarbejd en god CV og motiveret ansøgning, både på Dansk og Engelsk, gennem Prosa"),
				new ToDoItem("Lav denne ToDo-liste app lyserød og mere pæn")
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
