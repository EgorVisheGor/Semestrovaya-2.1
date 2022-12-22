namespace WebServer.Models;

public class HttpPOST : Attribute
{
    public string MethodURI;

    public HttpPOST(string methodURI)
    {
        MethodURI = methodURI;
    }
}