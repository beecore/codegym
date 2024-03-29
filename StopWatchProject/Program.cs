﻿using System;

namespace StopWatchProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StopWatch stopwatch = new StopWatch();

            stopwatch.Start();

            int[] numbers = GenerateRandomNumbers(100000);
            SelectionSort(numbers);
            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.GetElapsedTime();
            Console.WriteLine("Elapsed Time: " + elapsedTime.TotalMilliseconds + " milliseconds");
        }

        private static int[] GenerateRandomNumbers(int length)
        {
            Random rand = new Random();
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = rand.Next();
            }
            return numbers;
        }

        private static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
    }
}