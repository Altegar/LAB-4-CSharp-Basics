// Сушинський Ігор
// Лабораторна робота № 4
// Одновимірні масиви.
// Варіант 3

namespace LAB_4_CSharp
{
    internal class Program
    {
        private static void Create(int[] a)
        {
            Random r = new();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-10, 10);
            }
        }

        private static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0,4}", a[i]);

            Console.WriteLine();
        }

        private static int OddCount(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    count++;
            }
            return count;
        }

        private static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            Create(a);
            Print(a);

            Console.WriteLine($"The number of odds = {OddCount(a)}");
        }
    }
}