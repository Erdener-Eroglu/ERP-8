namespace AracEnvanter.Models;

public abstract class BaseModel
{
    public Guid Id { get; set; } = new Guid();
    public DateTime CreatedTime { get; set; } = DateTime.Now;
}
