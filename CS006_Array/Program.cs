namespace CS006_Array;

class Program
{
    static void Main(string[] args)
    {
        // declare array, not initialize
        int[] arr1;

        // initialize array
        arr1 = new int[10];

        // declare and initialize array
        int[,] arr2 = new int[2, 3];
        arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        // declare and initialize array with values
        int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
        string[] arr4 = new string[] { "Iphone", "Samsung", "Nokia" };
        double[] arr5 = { 1.2, 2.3, 3.4, 4.5 };

        // access array element
        for (int i = 0; i < 10; i++)
        {
            arr1[i] = i + 1;
        }

        // print the information of array
        Console.WriteLine("Length of arr2: " + arr2.Length);
        Console.WriteLine("Rank of arr2: " + arr2.Rank);
        Console.WriteLine("Max of arr2: " + arr2.Cast<int>().Max());
        Console.WriteLine("Min of arr2: " + arr2.Cast<int>().Min());
        Console.WriteLine("Sum of arr2: " + arr2.Cast<int>().Sum());
        Console.WriteLine("Average of arr2: " + arr2.Cast<int>().Average());
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                Console.Write(arr2[i, j] + " ");
            }
            Console.WriteLine();
        }

        // clone array
        int[,] arr2Clone = (int[,])arr2.Clone();
        foreach (int i in arr2Clone)
        {
            Console.Write(i + " ");
        }

        // print even number in array
        Predicate<int> isEven = delegate (int number)
        {
            return number % 2 == 0;
        };

        Action<int> printNumber = (int number) => Console.Write(number + " ");
        int[] evenNumbers = Array.FindAll(arr1, isEven);
        Console.Write("\nEven number in arr1: ");
        Array.ForEach(evenNumbers, printNumber);
        Console.WriteLine();
    }
}
