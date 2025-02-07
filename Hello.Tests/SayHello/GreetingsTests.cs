using Hello.SayHello;

namespace Hello.Tests.SayHello;

internal class StubDecorator : IDecorator
{
    public string ApplyTo(string message)
    {
        return $"{message} with stub decoration";
    }
}

public class GreetingsTests
{
    [Fact]
    public void SayHelloToName()
    {
        var greetings = new Greetings(new StubDecorator());

        var result = greetings.SayHelloTo("Fabien");

        Assert.True(result.IsSuccess);
        Assert.Equal("Hello Fabien with stub decoration", result.Value);
    }

    [Fact]
    public void ErrorOnEmptyName()
    {
        var greetings = new Greetings(new StubDecorator());

        var result = greetings.SayHelloTo("");

        Assert.True(result.IsFailure);
        Assert.Equal("Name cannot be empty", result.Error);
    }
}