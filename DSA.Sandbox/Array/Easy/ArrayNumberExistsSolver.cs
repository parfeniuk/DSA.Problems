namespace DSA.Sandbox
{
    public class ArrayNumberExistsSolver
    {
        // Given an array of integers, return true if the number exists in the array, otherwise return false.
        // Example 1:
        // Input: [1, 2, 3, 4, 5], 3
        // Output: true
        // Example 2:
        // Input: [1, 2, 3, 4, 5], 6
        // Output: false

        // Constraints:
        // Solution should be efficient in terms of time complexity
        // The array can contain up to 2000000 elements
        public static bool NumberExists(int[] arr, int num)
        {
            // Iterate through the array and check if the number exists
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
