namespace DSA.Sandbox.Math.Easy
{
    // Leetcode 231. Power of Two
    // Non - recursive solution
    public static class IsPowerOfTwoSolver
    {
        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            if (n == 1) 
            {
                return true;
            }

            while (n % 2 == 0) 
            {
                n /= 2;
            }

            return n == 1;
        }
    }
}
