﻿using System.Diagnostics;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("How long is the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] MyArray = CreateArray(size, n);
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
                Console.Write(",");
            }
            menu(MyArray);
        }
        static int[] CreateArray(int size, Random r)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next(1, 100);
            }
            return array;
        }
        static void menu(int[] array)
        {
            Console.WriteLine("Select what you want to do");
            Console.WriteLine("1: Linear search");
            Console.WriteLine("2: Binary search");
            Console.WriteLine("3: Bubble sort");
            Console.WriteLine("4: Merge sort");
            Console.WriteLine("5: Quit");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("What number do you want to find");
                int NumToFind = Convert.ToInt32(Console.ReadLine());
                LinearSearch(array, NumToFind);
            }
            else if (option == 2)
            {
                Console.WriteLine("What number do you want to find");
                int NumToFind = Convert.ToInt32(Console.ReadLine());
                //BinarySearch(array, NumToFind);
            }
            else if (option == 3)
            {
                BubbleSort(array);
            }
            else if (option == 4)
            {

            }
            else if (option == 5)
            {

            }
            else
            {
                Console.WriteLine("Please type in a number");
            }
        }
        
        static void BubbleSort(int[] a)
        {
            int temp = 0;
            bool swap = false;
            int passes = 0;
            do
            {
                swap = false;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    passes++;
                    if (a[i] > a[i + 1])
                    {
                        a[i] = temp;
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap = false);
            Console.WriteLine($"It took {passes} passes.");
            Console.WriteLine("Your sorted array is:");
            for (int i = 0; i > a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static int LinearSearch(int[] a, int numToFind)
        {
            int index = 0;
            for (int i = 0; i >= a.Length; i++)
            {
                if (a[i] == numToFind)
                {
                    index = i;
                }
            }
            Console.WriteLine($"Your number is at index {index}");
            return index;
        }
       // static bool BinarySearch(int[] a, int numToFind)
        //{
        //}
            
    }
}
