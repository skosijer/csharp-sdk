namespace TestSdk.Http;

public class Environment
{
    internal Uri Uri { get; private set; }

    private Environment(string uri)
    {
        Uri = new Uri(uri);
    }

    public static Environment Default { get; } = new("http://petstore.swagger.io/v1/");
}
