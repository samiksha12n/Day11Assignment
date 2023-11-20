using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAssignment
{
    internal class Program
    {
        public static void Quicksort(int[] arr)
        {
            Quicksort(arr, 0, arr.Length - 1);
        }
        private static void Quicksort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                Quicksort(array, left, pivotIndex - 1);
                Quicksort(array, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    swap(array, i, j);
                }
            }
            swap(array, i + 1, right);
            return i + 1;
        }
        private static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static int[] GenerateRandomArray(int size)
        {
            int[] arr = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(100); // Generates random integers between 0 to 99
            }
            return arr;
        }
        static void Main(string[] args)
        {
            //elements-50
            int sizee50 = 50;
            int[] arraye50 = GenerateRandomArray(sizee50);
            Console.WriteLine("original array");
            Print(arraye50);
            Stopwatch stopwatche50 = new Stopwatch();
            stopwatche50.Start();
            Quicksort(arraye50);
            stopwatche50.Stop();
            Console.WriteLine("after quick sort");
            Print(arraye50);
            Console.WriteLine($"ArraySize {arraye50.Length} time taken {stopwatche50.Elapsed.TotalMilliseconds} milliseconds");

            //elements-30
            int sizee30 = 30;
            int[] arraye30 = GenerateRandomArray(sizee30);
            Console.WriteLine("original array");
            Print(arraye30);
            Stopwatch stopwatche30 = new Stopwatch();
            stopwatche30.Start();
            Quicksort(arraye30);
            stopwatche30.Stop();
            Console.WriteLine("after quick sort");
            Print(arraye30);
            Console.WriteLine($"ArraySize {arraye30.Length}  time taken  {stopwatche30.Elapsed.TotalMilliseconds} milliseconds");

            //elements-20
            int sizee20 = 20;
            int[] arraye20 = GenerateRandomArray(sizee20);
            Console.WriteLine("original array");
            Print(arraye20);
            Stopwatch stopwatche20 = new Stopwatch();
            stopwatche20.Start();
            Quicksort(arraye20);
            stopwatche20.Stop();
            Console.WriteLine("after quick sort");
            Print(arraye20);
            Console.WriteLine($"ArraySize {arraye20.Length}   time taken   {stopwatche20.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();
        }
    }
}