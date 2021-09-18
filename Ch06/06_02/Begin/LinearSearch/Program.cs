﻿using System;
using static System.Console;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            int theValue = 7;
            int[] array = new int[] { 1, 4, 5, 7, 9, 22 };

            WriteLine("Our array contains:");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\n\nThe result of a linear search for {theValue} is: ");
            WriteLine(linearSearch(array, theValue));
        }

        static int linearSearch(int[] a, int x)
        {
            

            // Step 2
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }

            // Step 3
            return -1;
        }
    }
}
