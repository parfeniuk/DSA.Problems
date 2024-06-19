namespace DSA.Sandbox.DepthFirstSearch.Easy
{
    public static class BinaryTreeInOrderTraversalSolver
    {
        public static IList<int> InOrderTraversal(TreeNode root)
        {
            var result = new List<int>();
            InOrderTraversal(root, result);
            return result;
        }

        private static void InOrderTraversal(TreeNode root, IList<int> result)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraversal(root.left, result);
            result.Add(root.val);
            InOrderTraversal(root.right, result);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
