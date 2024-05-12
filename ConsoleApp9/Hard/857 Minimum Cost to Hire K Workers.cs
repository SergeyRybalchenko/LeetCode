namespace LeetCode.Hard;

public static class _857
{
    public static double MincostToHireWorkers(int[] quality, int[] wage, int k)
    {
        var workers = quality.Select((t, i) => new KeyValuePair<int, double>(t, (double)wage[i] / t))
            .OrderBy(x => x.Value)
            .ToList();

        var totalQuality = 0;
        var minCost = 0d;
        var heap = new PriorityQueue<int, int>();

        for (var i = 0; i < quality.Length; i++)
        {
            heap.Enqueue(workers[i].Key, -1 * workers[i].Key);
            totalQuality += workers[i].Key;

            if (i + 1 < k) continue;

            minCost = minCost == 0
                ? totalQuality * workers[i].Value
                : Math.Min(minCost, totalQuality * workers[i].Value);

            totalQuality -= heap.Dequeue();
        }

        return minCost;
    }

    public static void InvokeTest()
    {
        var quality = new[] { 10, 20, 5 };
        var wage = new[] { 70, 50, 30 };
        const int k = 2;

        var result = MincostToHireWorkers(quality, wage, k);

        Console.WriteLine($"Expected: 105.00000, Actual: {result}");
    }
}