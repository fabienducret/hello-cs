using Hello.SayHello;

namespace Hello.Tests.SayHello;

internal class StubDecorator : IDecorator
{
    public string ApplyTo(string name)
    {
        return name + " with stub decoration";
    }
}

public class GreetingsTests
{
    [Fact]
    public void SayHelloToName()
    {
        var greetings = new Greetings(new StubDecorator());

        Assert.Equal("Hello Fabien with stub decoration", greetings.SayHelloTo("Fabien"));
    }

    [Fact]
    public void ThrowErrorOnEmptyName()
    {
        var greetings = new Greetings(new StubDecorator());

        var exception = Assert.Throws<ArgumentException>(() => greetings.SayHelloTo(""));

        Assert.Equal("Name cannot be empty", exception.Message);
    }
}