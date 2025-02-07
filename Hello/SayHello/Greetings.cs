using CSharpFunctionalExtensions;

namespace Hello.SayHello;

public interface IDecorator
{
    public string ApplyTo(string message);
}

public class Greetings(IDecorator decorator)
{
    public Result<string> SayHelloTo(string name)
    {
        return name switch
        {
            null or "" => Result.Failure<string>("Name cannot be empty"),
            _ => decorator.ApplyTo($"Hello {name}")
        };
    }
}