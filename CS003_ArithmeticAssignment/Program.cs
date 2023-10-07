namespace CS003_ArithmeticAssignment;

class Program
{
    static void Main(string[] args)
    {   
        // Declare variables
        decimal a, b;

        // Get input from user
        Console.Write("Enter a: ");
        a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter b: ");
        b = Convert.ToDecimal(Console.ReadLine());

        // Display result
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));
        Console.WriteLine("a++ = " + (a++));
        Console.WriteLine("a-- = " + (a--));
        Console.WriteLine("++a = " + (++a));
        Console.WriteLine("--a = " + (--a));
    }
}
