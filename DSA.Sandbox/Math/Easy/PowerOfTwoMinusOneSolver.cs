namespace DSA.Sandbox.Math.Easy
{
    // Given a number n, return 2^(n - 1) power.
    // 
    public static class PowerOfTwoMinusOneSolver
    {
        // Time complexity: O(2^n)
        // Space complexity: O(n)
        public static int PowerOfTwoMinusOneIterative(int n)
        {
            int result = 1;

            for (int i = 0; i < n - 1; i++)
            {
                result *= 2;
            }

            return result;
        }

        public static int PowerOfTwoMinusOne(int n) 
        {
            if (n <= 1) 
            {
                return 1;
            }

            return PowerOfTwoMinusOne(n - 1) + PowerOfTwoMinusOne(n - 1);
        }
    }
}
