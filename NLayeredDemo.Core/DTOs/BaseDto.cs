namespace NLayeredDemo.Core.DTOs;

public abstract class BaseDto
{
    public int Id { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime UpdatedTime { get; set; }
}