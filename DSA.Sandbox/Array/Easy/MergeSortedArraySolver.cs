namespace DSA.Sandbox.Array.Easy
{
    public static class MergeSortedArraySolver
    {
        // Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
        // The number of elements initialized in nums1 and nums2 are m and n respectively.
        // You may assume that nums1 has a size equal to m + n such that it has enough space to hold additional elements from nums2.

        // The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
        // To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,
        // and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

        // Constraints:
        // 0 <= n, m <= 200
        // 1 <= n + m <= 200
        // nums1.length == m + n
        // nums2.length == n
        // -10^9 <= nums1[i], nums2[i] <= 10^9

        // Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        // Output: [1,2,2,3,5,6]
        // Input: nums1 = [1], m = 1, nums2 = [], n = 0
        // Output: [1]
        // Input: nums1 = [0], m = 0, nums2 = [1], n = 1
        // Output: [1]
        // Input: nums1 = [4,5,6,0,0,0], m = 3, nums2 = [1,2,3], n = 3
        // Output: [1,2,3,4,5,6]
        // Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [4,5,6], n = 3
        // Output: [1,2,3,4,5,6]

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // Start from the rightmost digit

            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            // Compare the last elements of both arrays and put the greater one at the end of the first array
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            // If there are any remaining elements in the second array, put them at the beginning of the first array
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
