/*
Author: Ramya Kosaraju
Date: 2/28/2024
Comments: This C# Console Application code demonstrates the
   Bubble Sort Algorithm. No input
   is required for the script. It will execute without
   input against two pre-populated arrays.
*/
using System;
int[] array = { 3, 62, 5, 16, 4, 10 };  //input array

Console.WriteLine("Original array: " + string.Join(", ", array)); //printing of input array

// Bubble Sort
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = 0; j < array.Length - 1 - i; j++)
    {
        if (array[j] > array[j + 1])  //comparing numbers
        {
            // Swapping of numbers
            (array[j], array[j + 1]) = (array[j + 1], array[j]);
        }
    }
}
//output is getting printed using below line of code
Console.WriteLine("Sorted array: " + string.Join(", ", array));
