namespace NLayeredDemo.Core.Models;

public class Team : BaseModel
{
    public string TeamName { get; set; }
    public ICollection<User> Users { get; set; } //navigation property 
}