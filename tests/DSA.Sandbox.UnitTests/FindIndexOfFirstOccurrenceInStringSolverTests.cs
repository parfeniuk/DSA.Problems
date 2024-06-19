using Xunit;

namespace DSA.Sandbox.UnitTests
{
    public class FindIndexOfFirstOccurrenceInStringSolverTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void FindIndexOfFirstOccurrenceInString_ShouldReturnIndexOfFirstOccurrence(string s, string sub, int expected)
        {
            // Arrange & Act
            var actual = FindIndexOfFirstOccurrenceInStringSolver.FindIndexOfFirstOccurrenceInString(s, sub);

            // Assert
            Assert.Equal(expected, actual);
        }
        public static TheoryData<string, string, int> TestData => new()
        {
            { "hello", "ll", 2 },
            { "aaaaa", "bba", -1 },
            { "sadbutsad", "sad", 0 },
            { "leetcode", "leeto", -1 },
            { "hello", "hello", 0 },
            { "hello", "o", 4 },
            { "hello", "helloo", -1 },
            { "hello", "", -1 },
            { "", "hello", -1 },
            { "", "", 0 },
            { "hello", "hellohello", -1 },
            { "hello", "hellohellohello", -1 },
            { "hello", "hellohellohellohello", -1 },
            { "hello", "hellohellohellohellohello", -1 },
            { "hello", "hellohellohellohellohellohello", -1 },
            { "hello", "hellohellohellohellohellohellohello", -1 },
            { "hello", "hellohellohellohellohellohellohellohello", -1 },
            { "hello", "hellohellohellohellohellohellohellohellohello", -1 },
            { "hello", "", -1}
        };
    }
}
