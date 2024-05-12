namespace LeetCode;

public sealed class Utils
{
    public static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            foreach (var value in row) Console.Write(value + " ");
            Console.WriteLine();
        }
    }
}