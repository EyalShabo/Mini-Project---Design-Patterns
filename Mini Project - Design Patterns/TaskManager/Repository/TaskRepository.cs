namespace Mini_Project___Design_Patterns.TaskManager.Repository;

public class TaskRepository {
    private static TaskRepository _instance = new TaskRepository();
    private List<Task> _tasks = new List<Task>();
    
    private TaskRepository() {}
    
    public static TaskRepository GetInstance() => _instance;

    public void AddTask(Task task) => _tasks.Add(task);
    public void DeleteTask(int index) => _tasks.RemoveAt(index);
    public void UpdateTask(int index, Task task) => _tasks[index] = task;
    public List<Task> GetTasks() => _tasks;
}