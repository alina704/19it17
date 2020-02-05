using System;

namespace dgfhj2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int g = 0;
            int max = 0;
            Console.Write("Введите N : ");
            int N = Convert.ToInt32(Console.ReadLine());

            while (N > g)
            {
                Random random = new Random();
                int[] arr = new int[N - g];
                for (int i = 0; i < N - g; i++)
                {
                    arr[i] = random.Next(0, 1000);
                }


                Console.WriteLine("Исходный массив:");
                foreach (int x in arr)
                {
                    Console.Write(x + " ");
                }

                max = arr[g];

                for (int i = g; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        k = arr[g];
                        arr[i] = k;
                        arr[0] = max;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Полученный массив:");
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }

                N--;
            }
            Console.ReadKey();
        }
    }
}
        
    

