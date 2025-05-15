namespace Mini_Project___Design_Patterns.TaskManager.Models;

public sealed class Task {
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public Task(string title, string description, DateTime dueDate) {
        Title = title;
        Description = description;
        DueDate = dueDate;
    }
}