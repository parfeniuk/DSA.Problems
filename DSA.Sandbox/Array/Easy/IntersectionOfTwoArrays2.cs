namespace DSA.Sandbox.Array.Easy
{
    public static class IntersectionOfTwoArrays2Solver
    {
        // Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
        // Constraints:
        // 1 <= nums1.length, nums2.length <= 1000
        // 0 <= nums1[i], nums2[i] <= 1000
        // Input: nums1 = [1,2,2,1], nums2 = [2,2]
        // Output: [2,2]
        // Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        // Output: [4,9]
        // Explanation: [9,4] is also accepted.
        // 
        // Approach:
        // 1. Create a dictionary to store the frequency of each element in nums1.
        // 2. Iterate through nums2 and check if the element is present in the dictionary.
        // 3. If the element is present, add it to the result and decrement the frequency in the dictionary.
        // 4. Return the result.
        public static int[] FindIntersection(int[] nums1, int[] nums2)
        {
            var frequencyMap = new Dictionary<int, int>();
            var result = new List<int>();

            foreach (var num in nums1)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            foreach (var num in nums2)
            {
                if (frequencyMap.ContainsKey(num) && frequencyMap[num] > 0)
                {
                    result.Add(num);
                    frequencyMap[num]--;
                }
            }

            return result.ToArray();
        }
    }
}
