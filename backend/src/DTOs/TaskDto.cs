namespace ToDoListAPI.DTOs;

public class TaskDto
{
    public String Id { get; set; }
    public String Title { get; set; }
    public String Description { get; set; }
    public DateTime DueDate { get; set; }
    public String ListId { get; set; }
    public StatusEnum Status { get; set; }
    public enum StatusEnum
    {
        InProgressEnum = 2,
        CompletedEnum = 3
    }
}