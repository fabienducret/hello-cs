namespace Hello.SayHello;

public class DefaultDecorator : IDecorator
{
    public string ApplyTo(string message)
    {
        return $"--- {message} ---";
    }
}