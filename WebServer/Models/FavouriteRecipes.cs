namespace WebServer.Models;

public class FavouriteRecipes
{
    public int Id { get; set; }
    
    public Guid OwnerId { get; set; }
    
    public int RecipeId { get; set; }
}