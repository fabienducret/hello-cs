namespace Hello.SayHello;

public interface IDecorator
{
    public string ApplyTo(string name);
}

public class Greetings(IDecorator decorator)
{
    public string SayHelloTo(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name cannot be empty");

        return "Hello " + decorator.ApplyTo(name);
    }
}