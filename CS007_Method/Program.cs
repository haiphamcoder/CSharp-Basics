using MyLib;

namespace CS007_Method;

class Program
{
    static int Square(int x)
    {
        return x * x;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Square of 2 is {0}", Square(2));

        int x = 5;
        int y = 10;
        Console.WriteLine("Before swap: x = {0}, y = {1}", x, y);
        Method.Swap(ref x, ref y);
        Console.WriteLine("After swap: x = {0}, y = {1}", x, y);

        int[] arr;
        Method.InitArray(out arr);
        Console.Write("Array: ");
        foreach (int i in arr)
        {
            Console.Write("{0} ", i);
        }
    }
}
