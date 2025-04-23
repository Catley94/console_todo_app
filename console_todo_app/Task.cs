namespace console_todo_app;

public class Task
{
    int Id { get; }
    public string? ToDo { get; private set; }

    public Task(int _Id, string _ToDo)
    {
        Id = _Id;
        ToDo = _ToDo;
    }
}