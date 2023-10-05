namespace CS001_HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // This is a comment on a single line
        // Print "Hello, World!" to the console
        Console.WriteLine("Hello, World!");

        /*
         * This is a comment on multiple lines
         * Print "Hello, C# NET CORE!" to the console
         */
        Console.WriteLine("Hello, C# NET CORE!");

        // Print the sum of two numbers
        int a = 5;
        int b = 10;
        Console.WriteLine("Sum of {0} and {1} is {2}", a, b, Sum(a, b));
    }

    // This is XML documentation
    /// <summary>
    /// Calculate the sum of two numbers
    /// </summary>
    /// <param name="a">first number</param>
    /// <param name="b">second number</param>
    /// <returns>sum of two numbers</returns>
    static int Sum(int a, int b)
    {
        return a + b;
    }
}
