namespace LeetCode.Easy;

public static class _2331
{
    public static bool EvaluateTree(TreeNode node)
    {
        return node.val switch
        {
            2 => EvaluateTree(node.left) || EvaluateTree(node.right),
            3 => EvaluateTree(node.left) && EvaluateTree(node.right),
            1 => true,
            0 => false,
            _ => false
        };
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static void InvokeTest()
    {
        var root = new TreeNode(
            2,
            new TreeNode(1),
            new TreeNode(3, new TreeNode(0), new TreeNode(1))
        );

        var result = EvaluateTree(root);
        Console.WriteLine($"Output: {result}");
    }
}