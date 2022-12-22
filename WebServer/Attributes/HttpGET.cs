namespace WebServer.Models;

public class HttpGET : Attribute
{
    public string MethodURI;

    public HttpGET(string methodURI)
    {
        MethodURI = methodURI;
    }
}