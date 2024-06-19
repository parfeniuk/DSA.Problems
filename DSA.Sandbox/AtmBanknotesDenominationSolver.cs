namespace DSA.Sandbox
{
    public static class AtmBanknotesDenominationSolver
    {
        //        An ATM has three cartridges for different denominations:
        //•	10 EUR cartridge
        //•	50 EUR cartridge
        //•	100 EUR cartridge
        //Now we want to pay out following amounts from the ATM:
        //•	30 EUR
        //•	50 EUR
        //•	60 EUR
        //•	80 EUR
        //•	140 EUR
        //•	230 EUR
        //•	370 EUR
        //•	610 EUR
        //•	980 EUR
        //Write a program which will calculate for each payout the possible combinations which the ATM can pay out.
        //For example, for 100 EUR the available payout denominations would be:
        //•	10 x 10 EUR
        //•	1 x 50 EUR + 5 x 10 EUR
        //•	2 x 50 EUR
        //•	1 x 100 EUR
        //The program should be able to handle any payout amount.
        //The program should be written in C#.

        public static void CalculatePossibleCombinations(int amount)
        {
            var cartridges = new int[] { 10, 50, 100 };
            var combinations = new List<List<int>>();
            // Calculate all possible combinations
            CalculatePossibleCombinations(amount, cartridges, 0, new List<int>(), combinations);
            // Print all possible combinations
            foreach (var combination in combinations)
            {
                Console.WriteLine(string.Join(" + ", combination));
            }
        }

        // Recursive function to calculate all possible combinations
        // amount - the amount to be paid out
        // cartridges - the available cartridges
        // index - the current cartridge index
        // currentCombination - the current combination
        // combinations - the list of all possible combinations
        // Time complexity: O(3^n)
        // Space complexity: O(n)
        // where n is the number of cartridges
        // The time complexity is O(3^n) because for each cartridge we have 3 possibilities: 0, 1, or 2.
        // The space complexity is O(n) because we are using recursion and storing the current combination.
        //
        private static void CalculatePossibleCombinations(int amount, int[] cartridges, int index, List<int> currentCombination, List<List<int>> combinations)
        {
            // Base case
            // If the amount is 0, we have found a valid combination
            // Add the current combination to the list of combinations
            if (amount == 0)
            {
                combinations.Add(new List<int>(currentCombination));
                return;
            }

            // If the amount is negative or the index is out of bounds, return
            if (amount < 0 || index >= cartridges.Length)
            {
                return;
            }

            // Try all possible combinations for the current cartridge
            // Recursively call the function with the remaining amount and the next cartridge
            // Add the current cartridge to the current combination
            // Backtrack by removing the current cartridge from the current combination
            for (var i = 0; i <= amount / cartridges[index]; i++)
            {
                // Add the current cartridge to the current combination
                // For example, if we have 2 x 50 EUR, add 50 EUR to the current combination twice
                // This is a common pattern in backtracking algorithms
                // We add the current cartridge i times to the current combination
                // For example, if we have 2 x 50 EUR, we add 50 EUR to the current combination twice
                // This is necessary to try all possible combinations
                for (var j = 0; j < i; j++)
                {
                    currentCombination.Add(cartridges[index]);
                }

                // Recursively call the function with the remaining amount and the next cartridge
                // For example, if we have 2 x 50 EUR, we need to calculate the combinations for the remaining amount
                // amount - 2 * 50 EUR = amount - 100 EUR
                // We also need to move to the next cartridge (index + 1)
                // This is necessary to try all possible combinations
                CalculatePossibleCombinations(amount - i * cartridges[index], cartridges, index + 1, currentCombination, combinations);

                // Backtrack
                // Remove the current cartridge from the current combination
                // This is necessary to try the next combination
                // For example, if we have 2 x 50 EUR, we need to remove both 50 EUR before trying 1 x 100 EUR
                // Otherwise, the combination would be 2 x 50 EUR + 1 x 100 EUR
                // Instead of 2 x 50 EUR and 1 x 100 EUR separately
                // This is a common pattern in backtracking algorithms
                for (var j = 0; j < i; j++)
                {
                    currentCombination.RemoveAt(currentCombination.Count - 1);
                }
            }
        }

    }
}
