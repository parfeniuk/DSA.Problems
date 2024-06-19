namespace DSA.Sandbox.Array.Easy
{
    public static class ConvertSortedArrayToBinarySearchTreeSolver
    {
        // Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
        // A height-balanced binary tree is a binary tree in which the depth of the two subtrees of every node never differs by more than one.
        // Constraints:
        // 1 <= nums.length <= 10^4
        // -10^4 <= nums[i] <= 10^4
        // nums is sorted in a strictly increasing order.
        // Input: nums = [-10,-3,0,5,9]
        // Output: [0,-3,9,-10,null,5]
        // Explanation: [0,-10,5,null,-3,null,9] is also accepted:
        //      0
        //     / \
        //   -3   9
        //   /   /
        // -10  5
        // Input: nums = [1,3]
        // Output: [3,1]
        // Explanation: [1,3] is also accepted:
        //   3
        //  /
        // 1
        // Input: nums = [0,1,2,3,4,5]
        // Output: [3,1,5,0,2,4]
        // Explanation: [0,2,4,1,3,5] is also accepted:
        //      3
        //     / \
        //   1   5
        //  /   / \
        // 0  2     4

        // Approach:
        // 1. The middle element of the array will be the root of the BST.
        // 2. The left half of the array will be the left subtree of the root.
        // 3. The right half of the array will be the right subtree of the root.
        // 4. Recursively build the left and right subtrees.

        public static TreeNode? ConvertToBinarySearchTree(int[] nums) 
        {
            return CreateBalancedBinarySearchTree(nums, 0, nums.Length - 1);
        }

        private static TreeNode? CreateBalancedBinarySearchTree(int[] nums, int start, int end)
        {
            // Base case
            if (start > end)
            {
                return null;
            }

            // Find the middle element of the array
            var root = new TreeNode();
            var mid = (start + end) / 2;

            // Set the middle element of the array as the root
            root.Value = nums[mid];
            // Recursively build the left and right subtrees
            root.Left = CreateBalancedBinarySearchTree(nums, start, mid - 1);
            root.Right = CreateBalancedBinarySearchTree(nums, mid + 1, end);

            // Return the root of the BST
            return root;
        }
    }

   public class TreeNode()
    {
        public int Value;
        public TreeNode? Left;
        public TreeNode? Right;
    }
}
