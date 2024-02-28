using System;
class BubbleSort
{
    static void Main()
    {
        int[] array = { 3, 62, 5, 16, 4, 10 };

        Console.WriteLine("Original array: " + string.Join(", ", array));

        // Bubble Sort
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }

        Console.WriteLine("Sorted array: " + string.Join(", ", array));
    }
}
