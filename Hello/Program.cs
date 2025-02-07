using Hello;
using Hello.SayHello;

var greetings = new Greetings(new DefaultDecorator());
var arguments = new Arguments(args);

if (!arguments.IsProvided()) Console.Error.WriteLine("No arguments provided");

arguments
    .GetNames()
    .Select(name => greetings.SayHelloTo(name))
    .ToList()
    .ForEach(Console.WriteLine);