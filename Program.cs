namespace CSharpDocs;

/// <summary>
/// Program class
/// </summary>
public class Program
{
    /// <summary>
    /// Say hello to someone
    /// </summary>
    ///
    /// <param name="who">
    /// Who to say hello to
    /// </param>
    public static void SayHello(string who)
    {
        Console.WriteLine($"Hey {who} how ya doin");
    }

    /// <summary>
    /// Program entry point
    /// </summary>
    ///
    /// <param name="args">
    /// Command-line arguments
    /// </param>
    static void Main(string[] args)
    {
        SayHello("Jamie");
    }
}
