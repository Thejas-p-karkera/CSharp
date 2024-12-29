using System;

class Program
{
    static void Main()
    {
        // Create a 1D array
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Create a 2D array
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Demonstrate array members
        Console.WriteLine("** 1D Array **");
        Console.WriteLine($"Length of numbers array: {numbers.Length}"); // Total number of elements
        Console.WriteLine($"Rank of numbers array: {numbers.Rank}"); // Number of dimensions
        Console.WriteLine($"Element at index 2: {numbers.GetValue(2)}"); // Get value at index
        numbers.SetValue(99, 2); // Set value at index
        Console.WriteLine($"Updated element at index 2: {numbers.GetValue(2)}");

        // Clone the array
        int[] clonedNumbers = (int[])numbers.Clone();
        Console.WriteLine("Cloned Array: " + string.Join(", ", clonedNumbers));

        Console.WriteLine("\n** 2D Array **");
        Console.WriteLine($"Length of matrix: {matrix.Length}"); // Total number of elements
        Console.WriteLine($"Rank of matrix: {matrix.Rank}"); // Number of dimensions
        Console.WriteLine($"Element at (1, 1): {matrix.GetValue(1, 1)}"); // Get value at (1,1)
        matrix.SetValue(99, 2, 2); // Set value at (2,2)
        Console.WriteLine($"Updated element at (2, 2): {matrix.GetValue(2, 2)}");
        Console.WriteLine($"Number of rows in matrix: {matrix.GetLength(0)}"); // Get length of the first dimension
        Console.WriteLine($"Number of columns in matrix: {matrix.GetLength(1)}");

        // Display matrix
        Console.WriteLine("\nMatrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
