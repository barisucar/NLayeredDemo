namespace NLayeredDemo.Core.Models;

public class User : BaseModel
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int TeamId { get; set; } //foreign key
     
    public Team Team { get; set; } //navigation property

}