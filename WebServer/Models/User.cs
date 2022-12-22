namespace WebServer.Models;

public class User
{
    public Guid Id { get; set; }
    
    public string Password { get; set; }
    
    public string Login { get; set; }
    
    public string Name { get; set; }
    
    public string Surname { get; set; }
    
    public string Patronymic { get; set; }
    
    public DateOnly DateOfBirth { get; set; }
    
    public string ImagePath { get; set; }
}