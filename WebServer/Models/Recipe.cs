namespace WebServer.Models;

public class Recipe
{
    public int Id { get; set; }
    
    public Guid AuthorId { get; set; }
    
    public Date DateOfPublishing { get; set; }
    
    public double Rating { get; set; } 
    
    public string[] Description { get; set; }
}