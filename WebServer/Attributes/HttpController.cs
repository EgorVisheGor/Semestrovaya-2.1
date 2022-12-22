namespace WebServer.Models;

public class HttpController : Attribute
{
    public string ControllerName;

    public HttpController(string controllerName)
    {
        ControllerName = controllerName;
    }
}