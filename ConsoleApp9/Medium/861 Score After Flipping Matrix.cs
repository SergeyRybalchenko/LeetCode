namespace LeetCode.Medium;

public static class _861
{
    public static int MatrixScore(int[][] grid)
    {
        for (var index = 0; index < grid.Length; index++)
        {
            var arr = grid[index];
            if (arr[0] == 0) grid[index] = InvertArr(arr);
        }

        for (var col = 0; col < grid[0].Length; col++)
        {
            var onesCount = 0;
            var zerosCount = 0;

            foreach (var arr in grid)
                if (arr[col] == 1)
                    onesCount++;
                else
                    zerosCount++;

            if (onesCount >= zerosCount) continue;

            foreach (var arr in grid)
                arr[col] = 1 - arr[col];
        }

        return grid.Sum(BinaryArrayToDecimal);
    }

    private static int[] InvertArr(int[] arr)
    {
        for (var i = 0; i < arr.Length; i++) arr[i] = 1 - arr[i];

        return arr;
    }

    private static int BinaryArrayToDecimal(int[] arr)
    {
        var num = 0;

        for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++) num += arr[i] * (int)Math.Pow(2, j);

        return num;
    }

    public static void InvokeTest()
    {
        var grid = new int[][]
        {
            new int[] { 0, 0, 1, 1 },
            new int[] { 1, 0, 1, 0 },
            new int[] { 1, 1, 0, 0 }
        };

        var result = MatrixScore(grid);
        Console.WriteLine(result);
    }
}