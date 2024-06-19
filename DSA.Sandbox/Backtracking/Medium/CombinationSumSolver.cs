namespace DSA.Sandbox.Backtracking.Medium
{
    public static class CombinationSumSolver
    {
        // Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target.
        // You may return the combinations in any order.
        // The same number may be chosen from candidates an unlimited number of times.
        // Two combinations are unique if the frequency of at least one of the chosen numbers is different.
        // It is guaranteed that the number of unique combinations that sum up to target is less than 150 combinations for the given input.
        // Constraints:
        // 1 <= candidates.length <= 30
        // 1 <= candidates[i] <= 200
        // All elements of candidates are distinct.
        // 1 <= target <= 500
        // Input: candidates = [2,3,6,7], target = 7
        // Output: [[2,2,3],[7]]
        // Explanation:
        // 2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
        // 7 is a candidate, and 7 = 7.
        // These are the only two combinations.
        // Input: candidates = [2,3,5], target = 8
        // Output: [[2,2,2,2],[2,3,3],[3,5]]
        // Input: candidates = [2], target = 1
        // Output: []
        // Input: candidates = [1], target = 1
        // Output: [[1]]
        // Input: candidates = [1], target = 2
        // Output: [[1,1]]
        // Approach:
        // 1. Use backtracking to generate all possible combinations.
        // 2. Sort the candidates array to avoid duplicate combinations.
        // 3. Start from the first candidate and recursively generate all possible combinations.
        // 4. If the current sum is equal to the target, add the current combination to the result.
        // 5. If the current sum is greater than the target, backtrack.
        // 6. If the current sum is less than the target, continue generating combinations.
        // 7. Time complexity: O(2^n)
        // 8. Space complexity: O(n)
        // where n is the number of candidates
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            // Sort the candidates array to avoid duplicate combinations
            System.Array.Sort(candidates);
            GenerateCombinations(candidates, target, 0, [], result);
            return result;
        }

        /// <summary>
        /// Recursively generate all possible combinations of candidates that sum up to the target.
        /// </summary>
        /// <param name="candidates">
        /// An array of distinct integers candidates
        /// </param>
        /// <param name="target">
        /// An integer target to sum up to
        /// </param>
        /// <param name="index">
        /// Current index in the candidates array
        /// </param>
        /// <param name="currentCombination">
        /// A list to store the current combination that sums up to the target
        /// </param>
        /// <param name="result">
        /// A list to store all unique combinations that sum up to the target
        /// </param>
        private static void GenerateCombinations(int[] candidates, int target, int index, List<int> currentCombination, List<IList<int>> result)
        {
            // Base case
            // We decrement the target until it reaches 0
            // If the target is 0, we have found a valid combination
            if (target == 0)
            {
                result.Add([.. currentCombination]);
                return;
            }

            // We start from the first candidate and recursively generate all possible combinations
            for (int i = index; i < candidates.Length; i++)
            {
                if (candidates[i] > target)
                {
                    break;
                }

                currentCombination.Add(candidates[i]);

                // Generate combinations recursively
                GenerateCombinations(candidates, target - candidates[i], i, currentCombination, result);

                // Backtrack
                // Remove the last element from the current combination
                // to explore other possibilities
                // For example, if the current combination is [2, 2, 3]
                // and the target is 7, we remove 3 to explore other possibilities
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}
