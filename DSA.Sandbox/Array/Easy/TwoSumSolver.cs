namespace DSA.Sandbox
{
    public static class TwoSumSolver
    {
        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        // You can return the answer in any order.
        // Example 1:
        // Input: nums = [2,7,11,15], target = 9
        // Output: [0,1]
        // Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        // Example 2:
        // Input: nums = [3,2,4], target = 6
        // Output: [1,2]
        // Example 3:
        // Input: nums = [3,3], target = 6
        // Output: [0,1]
        public static int[] TwoSum(int[] nums, int target)
        {
            // Create a dictionary to store the number and its index
            var map = new Dictionary<int, int>();

            // Iterate through the numbers and check if the addition to the target for the current number exists in the dictionary
            for (var i = 0; i < nums.Length; i++)
            {
                // Calculate the addition to the target for the current number
                var addition = target - nums[i];
                // If the addition exists in the dictionary, return the indices of the two numbers
                if (map.TryGetValue(addition, out int additionIndex))
                {
                    return [additionIndex, i];
                }
                // Otherwise, add the current number to the dictionary
                map[nums[i]] = i;
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
