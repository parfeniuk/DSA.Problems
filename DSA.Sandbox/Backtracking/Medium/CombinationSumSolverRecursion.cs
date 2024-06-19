namespace DSA.Sandbox.Backtracking.Medium
{
    public static class CombinationSumSolverRecursion
    {
        public static IList<IList<int>> CombinationSumRecursively(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            System.Array.Sort(candidates);
            CombinationSumRecursively(candidates, target, 0, [], result);
            return result;
        }

        private static void CombinationSumRecursively(int[] candidates, int target, int index, IList<int> currentResult, IList<IList<int>> result)
        {
            // Base Case
            if (target == 0)
            {
                result.Add([.. currentResult]);
                return;
            }

            if (target < 0 || index == candidates.Length)
            {
                return;
            }

            // Add candidate to the current result list
            currentResult.Add(candidates[index]);

            // Recursively traverse the state space tree in depth-first
            CombinationSumRecursively(candidates, target - candidates[index], index, currentResult, result);

            // Backtrack
            currentResult.RemoveAt(currentResult.Count - 1);

            // Recursively traverse the next branch
            CombinationSumRecursively(candidates, target, index + 1, currentResult, result);
        }
    }
}
