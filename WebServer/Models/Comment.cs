namespace WebServer.Models;

public class Comment
{
    public int Id { get; set; }
    
    public int RecipeId { get; set; }
    
    public Guid OwnerId { get; set; }
    
    public int Rating { get; set; }
    
    public Date DateOfPublishing { get; set; }
    
    public string Description { get; set; }


}