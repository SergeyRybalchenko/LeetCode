namespace LeetCode.Easy;

public sealed class _2373
{
    public static int[][] LargestLocal(int[][] grid)
    {
        var result = new int[grid.Length - 2][];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = new int[grid[i].Length - 2];

            for (var j = 0; j < result[i].Length; j++)
                result[i][j] = FindMaxInRange(grid, i, j, 3);
        }

        return result;
    }

    private static int FindMaxInRange(int[][] grid, int startX, int startY, int range)
    {
        return Enumerable.Range(startX, range)
            .SelectMany(i => Enumerable.Range(startY, range).Select(j => grid[i][j]))
            .Max();
    }


    public static void InvokeTest()
    {
        var grid1 = new int[][]
        {
            new int[] { 9, 9, 8, 1 },
            new int[] { 5, 6, 2, 6 },
            new int[] { 8, 2, 6, 4 },
            new int[] { 6, 2, 2, 2 }
        };

        var grid2 = new int[][]
        {
            new int[] { 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 2, 1, 1 },
            new int[] { 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1 }
        };

        Utils.PrintMatrix(LargestLocal(grid1));
        Console.WriteLine();
        Utils.PrintMatrix(LargestLocal(grid2));
    }
}