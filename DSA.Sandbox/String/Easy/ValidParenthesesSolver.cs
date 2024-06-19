namespace   DSA.Sandbox
{
    // Leetcode 20. Valid Parentheses
    public static class ValidParenthesesSolver
    {
        // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        // An input string is valid if:
        // Open brackets must be closed by the same type of brackets.
        // Open brackets must be closed in the correct order.
        // Example 1:
        // Input: s = "()"
        // Output: true
        // Example 2:
        // Input: s = "()[]{}"
        // Output: true
        // Example 3:
        // Input: s = "(]"
        // Output: false
        // Example 4:
        // Input: s = "([)]"
        // Output: false
        // Example 5:
        // Input: s = "{[]}"
        // Output: true
        // Constraints:
        // 1 <= s.length <= 104
        // s consists of parentheses only '()[]{}'.

        // Time complexity: O(n)
        // Space complexity: O(n)
        // Approach: Use a stack to store the opening brackets and pop the stack when a closing bracket is encountered
        // If the stack is empty or the closing bracket does not match the opening bracket, return false
        // If the stack is not empty after iterating through the string, return false
        // Otherwise, return true
        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if 
                    (
                       c == ')' && (stack.Count == 0 || stack.Pop() != '(')
                    || c == '}' && (stack.Count == 0 || stack.Pop() != '{')
                    || c == ']' && (stack.Count == 0 || stack.Pop() != '[')
                    )
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
