using CSharpFunctionalExtensions;
using Hello.SayHello;

var greetings = new Greetings(new DefaultDecorator());

args.Select(name => greetings.SayHelloTo(name))
    .ToList()
    .ForEach(result => result
        .TapError(error => Console.Error.WriteLine(error))
        .Tap(hello => Console.WriteLine(hello)));