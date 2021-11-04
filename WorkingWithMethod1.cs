using System;

namespace wwm1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Console.WriteLine("-----------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("-----------");
            Reverse(numbers);
            PrintNumbers(numbers);
        }
        static int[] GenerateNumbers()
        {
            Console.WriteLine("Enter the numbers of array to generate:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n]; 
            for(int i=0; i < n; i++)
            {
                int number = new Random().Next(20) + 1;
                array[i] = number;
            }
            return array;
        }
        static void Reverse(int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n / 2; i++)
            {
                int temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }
        }
        static void PrintNumbers(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
