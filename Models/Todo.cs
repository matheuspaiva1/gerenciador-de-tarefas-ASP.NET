namespace TWtodos2.Models;

public class Todo {
  public int Id { get; set; }
  public string Title { get; set; } = string.Empty;
  public DateTime CreatedAt { get; set; }
  public DateOnly DeadLine { get; set; }
  public DateOnly? FinishedAt { get; set; }
}