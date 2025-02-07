namespace Hello;

public class Arguments(string[] args)
{
    public bool IsProvided()
    {
        return args.Length > 0;
    }

    public string[] GetNames()
    {
        return args;
    }
}