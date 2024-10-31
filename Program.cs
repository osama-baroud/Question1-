using Figgle;
using HelloDotNet;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: HelloDotNet <text1> <text2> ...");
            Environment.Exit(1);
        }

        foreach (var arg in args)
        {
            AsciiArt.Write(arg);
        }
    }
}
