//Write a program in C# to read n number of values in an array and display it in reverse order.

namespace Assignment1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Input {n} number of elements in the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are: \n" + string.Join(", ", arr));
            Console.WriteLine("The values store into the array in reverse are:");
            for (int i = n - 1; i >= 0; i--)
            {
                if (i != n - 1)
                {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
            }

            //Array.Reverse(arr);
            //Console.WriteLine($"\nThe values store into the array in reverse are: \n" + string.Join(", ", arr));

        }
    }
}
