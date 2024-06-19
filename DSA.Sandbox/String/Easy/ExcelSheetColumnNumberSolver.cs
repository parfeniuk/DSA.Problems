namespace DSA.Sandbox
{
    // Leetcode 171. Excel Sheet Column Number
    // Link to the problem - https://leetcode.com/problems/excel-sheet-column-number/
    public static class ExcelSheetColumnNumberSolver
    {
        // Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.
        // Example 1:
        // Input: columnTitle = "A"
        // Output: 1
        // Example 2:
        // Input: columnTitle = "AB"
        // Output: 28
        // Example 3:
        // Input: columnTitle = "ZY"
        // Output: 701
        // Example 4:
        // Input: columnTitle = "FXSHRXW"
        // Output: 2147483647
        public static int TitleToNumber(string columnTitle)
        {
            int toBase = 26;
            int result = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                result+= (columnTitle[i] - 'A' + 1) * (int)System.Math.Pow(toBase, columnTitle.Length - i - 1);
            }
            return result;
        }
    }
}
