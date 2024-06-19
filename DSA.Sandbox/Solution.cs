namespace DSA.Sandbox 
{
    public static class Solution
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> result = [];
            System.Array.Sort(candidates);
            CombinationSum(candidates, target, 0, [], result);
            return result;
        }

        // Recursive method to walk the state space tree
        // Add items from candidates to the list (currentResult)
        private static void CombinationSum(int[] candidates, int target, int index, List<int> currentResult, List<IList<int>> result)
        {
            // Base Case
            if (target == 0)
            {
                result.Add([.. currentResult]);
                return;
            }

            if (target <= 0)
            {
                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                if (candidates[i] > target)
                {
                    break;
                }

                currentResult.Add(candidates[i]);
                CombinationSum(candidates, target - candidates[i], i, currentResult, result);
                currentResult.RemoveAt(currentResult.Count - 1);
            }
        }
    }
}