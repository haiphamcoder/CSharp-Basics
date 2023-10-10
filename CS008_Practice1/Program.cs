using Money;
namespace CS008_Practice1;

class Program
{
    static void Main(string[] args)
    {
        decimal inputNumber = 8877665544332211;
        string result = Utils.NumberToText(inputNumber);
        System.Console.WriteLine(result);
    }
}
 