using Project.Generators;

namespace Project.Api;

[GenerateService]
public class Todo
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public bool IsCompleted { get; set; }
}
