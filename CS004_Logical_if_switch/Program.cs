namespace CS004_Logical_if_switch;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.Write("Enter your age: ");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your height: ");
        var height = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter your weight: ");
        var weight = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Your name is {0}", name);
        var msg = age >= 18 ? "You are an adult" : "You are a child";
        Console.WriteLine(msg);
        if (height > 1.7m)
        {
            Console.WriteLine("You are tall");
        }
        else
        {
            Console.WriteLine("You are short");
        }
        if (weight > 70)
        {
            Console.WriteLine("You are fat");
        }
        else
        {
            Console.WriteLine("You are thin");
        }

        Console.WriteLine("Enter the month number: ");
        var month = Convert.ToInt32(Console.ReadLine());
        switch (month)
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            default:
                Console.WriteLine("Unknown month");
                break;
        }
    }
}
