namespace LeetCode.Medium;

public static class _1219
{
    public static int GetMaximumGold(int[][] grid)
    {
        var maxGold = 0;

        for (var i = 0; i < grid.Length; i++)
            for (var j = 0; j < grid[0].Length; j++)
                if (grid[i][j] != 0)
                    maxGold = Math.Max(maxGold, CollectGold(grid, i, j));

        return maxGold;
    }

    private static int CollectGold(IReadOnlyList<int[]> grid, int i, int j)
    {
        if (i < 0 || i >= grid.Count || j < 0 || j >= grid[0].Length || grid[i][j] == 0) return 0;

        var currentGold = grid[i][j];
        grid[i][j] = 0;

        var maxGold = 0;
        maxGold = Math.Max(maxGold, currentGold + CollectGold(grid, i + 1, j));
        maxGold = Math.Max(maxGold, currentGold + CollectGold(grid, i - 1, j));
        maxGold = Math.Max(maxGold, currentGold + CollectGold(grid, i, j + 1));
        maxGold = Math.Max(maxGold, currentGold + CollectGold(grid, i, j - 1));

        grid[i][j] = currentGold;
        return maxGold;
    }

    public static void InvokeTest()
    {
        var grid1 = new int[][]
        {
            new int[] { 0, 6, 0 },
            new int[] { 5, 8, 7 },
            new int[] { 0, 9, 0 }
        };
        Console.WriteLine("Input:");
        Utils.PrintMatrix(grid1);
        Console.WriteLine($"Output: {GetMaximumGold(grid1)}");

        var grid2 = new int[][]
        {
            new int[] { 1, 0, 7 },
            new int[] { 2, 0, 6 },
            new int[] { 3, 4, 5 },
            new int[] { 0, 3, 0 },
            new int[] { 9, 0, 20 }
        };
        Console.WriteLine("\nInput:");
        Utils.PrintMatrix(grid2);
        Console.WriteLine($"Output: {GetMaximumGold(grid2)}");
    }
}