namespace LeetCode.Easy;

public static class _1470
{
    public static int[] Shuffle(int[] nums, int n)
    {
        var result = new int[nums.Length];

        for (var i = 0; i < n; i++)
        {
            result[i * 2] = nums[i];
            result[i * 2 + 1] = nums[n + i];
        }

        return result;
    }

    public static void InvokeTest()
    {
        var nums1 = new int[] { 2, 5, 1, 3, 4, 7 };
        var n1 = 3;
        var result1 = Shuffle(nums1, n1);
        Console.WriteLine($"Input: [{string.Join(",", nums1)}], n = {n1}");
        Console.WriteLine($"Output: [{string.Join(",", result1)}]");
        Console.WriteLine();

        var nums2 = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
        var n2 = 4;
        var result2 = Shuffle(nums2, n2);
        Console.WriteLine($"Input: [{string.Join(",", nums2)}], n = {n2}");
        Console.WriteLine($"Output: [{string.Join(",", result2)}]");
        Console.WriteLine();

        var nums3 = new int[] { 1, 1, 2, 2 };
        var n3 = 2;
        var result3 = Shuffle(nums3, n3);
        Console.WriteLine($"Input: [{string.Join(",", nums3)}], n = {n3}");
        Console.WriteLine($"Output: [{string.Join(",", result3)}]");
    }
}