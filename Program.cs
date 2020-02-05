using System;

namespace rfghjj
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int k = 0;
            int first;
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(0, 10000);
            }

            
            for (int i = 0; i < N; i++)
            {
                if (arr[i] > max) { 
                    max = arr[i];
                    k = arr[0];
                    arr[i] = k;
                    arr[0] = max;
                }
            }
            first = max;
            Console.WriteLine(first);
            foreach(int i in arr)
            {
                Console.Write(i + "");
            }
        }

    }
}
