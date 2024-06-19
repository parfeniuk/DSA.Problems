namespace DSA.Sandbox.Array.Easy
{
    public static class PlusOneSolver
    {
        public static int[] PlusOne(int[] digits)
        {
            // Start from the rightmost digit
            // If the digit is less than 9, increment it and return the array
            // If the digit is 9, set it to 0 and continue to the next digits
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                // If the digit is 9, set it to 0
                digits[i] = 0;
            }

            // If we are here, it means all digits are 9
            int[] newNumber = new int[digits.Length + 1];
            newNumber[0] = 1;

            return newNumber;
        }
    }
}
