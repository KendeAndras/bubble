namespace buborek
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int[] bubble = new int[] { 10, 2, 310, 4, 60, 77, 1 };
            Array.Sort(bubble);
            int n = bubble.Length;
            for (int i = n-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (bubble[j] > bubble[j+1])
                    {
                        Swap(ref bubble[j], ref bubble[j+1]);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(bubble[i]);
            }
        }
    }
}