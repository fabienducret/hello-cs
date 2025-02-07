namespace Hello.SayHello;

public class DefaultDecorator : IDecorator
{
    public string ApplyTo(string name)
    {
        return name + " with default decoration";
    }
}