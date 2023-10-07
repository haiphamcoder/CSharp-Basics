namespace CS005_for_while;

class Program
{
    static void Main(string[] args)
    {
        // show all even numbers from 0 to 20
        for (int i = 0; i <= 20; i += 2)
        {
            Console.Write(i + "    ");
        }
        Console.WriteLine();

        // show all odd numbers and their squares from 1 to 10
        int j = 1;
        while (true)
        {
            Console.Write(j + "^2 = " + j * j + "    ");
            j += 2;
            if (j > 10)
            {
                break;
            }
        }
        Console.WriteLine();

        // show all numbers from 10 to 1
        int k = 10;
        do
        {
            Console.Write(k + "    ");
            k--;
        } while (k >= 1);
    }
}
