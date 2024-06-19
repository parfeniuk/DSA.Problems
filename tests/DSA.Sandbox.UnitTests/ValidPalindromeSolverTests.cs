using Xunit;

namespace DSA.Sandbox.UnitTests
{
    public class ValidPalindromeSolverTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void IsPalindrome_WhenStringIsPalindrome_ShouldReturnTrue(string input, bool expected)
        {
            // Arrange
            var result = ValidPalindromeSolver.IsPalindrome(input);
            
            Assert.Equal(expected, result);
        }

        public static TheoryData<string, bool> TestData => new()
        {
            { "A man, a plan, a canal: Panama", true },
            { "race a car", false },
            { "", true }
        };
    }
}
