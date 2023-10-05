

namespace CS002_VariablesConstantsIO;

class Program
{
    static void Main(string[] args)
    {
        // Data types built-in C#
        // Value types
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Value types");
        Console.ResetColor();
        Console.WriteLine($"sbyte: {sizeof(sbyte)} bytes [{sbyte.MinValue} -> {sbyte.MaxValue}]");
        Console.WriteLine($"byte: {sizeof(byte)} bytes [{byte.MinValue} -> {byte.MaxValue}]");
        Console.WriteLine($"short: {sizeof(short)} bytes [{short.MinValue} -> {short.MaxValue}]");
        Console.WriteLine($"ushort: {sizeof(ushort)} bytes [{ushort.MinValue} -> {ushort.MaxValue}]");
        Console.WriteLine($"int: {sizeof(int)} bytes [{int.MinValue} -> {int.MaxValue}]");
        Console.WriteLine($"uint: {sizeof(uint)} bytes [{uint.MinValue} -> {uint.MaxValue}]");
        Console.WriteLine($"long: {sizeof(long)} bytes [{long.MinValue} -> {long.MaxValue}]");
        Console.WriteLine($"ulong: {sizeof(ulong)} bytes [{ulong.MinValue} -> {ulong.MaxValue}]");
        Console.WriteLine($"float: {sizeof(float)} bytes [{float.MinValue} -> {float.MaxValue}]");
        Console.WriteLine($"double: {sizeof(double)} bytes [{double.MinValue} -> {double.MaxValue}]");
        Console.WriteLine($"decimal: {sizeof(decimal)} bytes [{decimal.MinValue} -> {decimal.MaxValue}]");
        Console.WriteLine($"char: {sizeof(char)} bytes [{char.MinValue} -> {char.MaxValue}]");
        Console.WriteLine($"bool: {sizeof(bool)} bytes [{bool.FalseString} -> {bool.TrueString}]");

        // Reference types
        string name = "John";
        Console.WriteLine("name: " + name);
        Console.WriteLine("    type: " + name.GetType());
        Console.WriteLine("    length: " + name.Length);

        // Object type
        object obj = 10;
        Console.WriteLine("obj: " + obj);
        Console.WriteLine("    type: " + obj.GetType());

        // Dynamic type
        dynamic dyn = 10;
        Console.WriteLine("dyn: " + dyn);
        Console.WriteLine("    type: " + dyn.GetType());
        dyn = "John";
        Console.WriteLine("dyn: " + dyn);
        Console.WriteLine("    type: " + dyn.GetType());

        // Var type
        var a = 10;
        Console.WriteLine("a: " + a.GetType());
        var b = "John";
        Console.WriteLine("b: " + b.GetType());
        var c = 10.5;
        Console.WriteLine("c: " + c.GetType());

        // Input in C#
        Console.WriteLine();
        Console.Write("Enter your name: ");
        name = Console.ReadLine() ?? "Unknown";
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter your weight: ");
        float weight = Convert.ToSingle(Console.ReadLine() ?? "0");
        Console.Write("Enter your height: ");
        double height = Convert.ToDouble(Console.ReadLine() ?? "0");
        dynamic address;
        Console.Write("Enter your address: ");
        address = Console.ReadLine() ?? "Unknown";
        Console.WriteLine($"Hello, {name}!, you are {age} years old, your weight is {weight}kg, your height is {height}cm, your address is {address}");
    }
}
