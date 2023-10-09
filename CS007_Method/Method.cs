namespace MyLib
{
    public class Method
    {
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void InitArray(out int[] arr)
        {
            arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * i;
            }
        }
    }
}