namespace DSA.Sandbox
{
    public static class MergeIntervalsSolver
    {
        // Given a collection of intervals, merge all overlapping intervals.
        // Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, 
        // and return an array of the non-overlapping intervals that cover all the intervals in the input.

        // Example 1:
        // Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
        // Output: [[1,6],[8,10],[15,18]]
        // Explanation: Since intervals[1, 3] and[2, 6] overlap, merge them into[1, 6].

        // Example 2:
        // Input: intervals = [[1,4],[4,5]]
        // Output: [[1,5]]
        // Explanation: Intervals[1, 4] and[4, 5] are considered overlapping.

        // Constraints:
        // 1 <= intervals.length <= 10^4
        // intervals[i].length == 2
        // 0 <= starti <= endi <= 10^4

        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return [];
            }
            
            System.Array.Sort(intervals, (a, b) => a[0] - b[0]);

            var result = new List<int[]>();
            var currentInterval = intervals[0];

            // Iterate through the intervals and merge overlapping intervals
            for (var i = 1; i < intervals.Length; i++)
            {
                var nextInterval = intervals[i];

                // If the current interval end is greater than or equal to the next interval start
                // then merge the intervals (i.e. set the current interval end to the max of the current and next interval end)
                // Otherwise, add the current interval to the result and set the current interval to the next interval
                if (currentInterval[1] >= nextInterval[0])
                {
                    currentInterval[1] = System.Math.Max(currentInterval[1], nextInterval[1]);
                }
                else
                {
                    result.Add(currentInterval);
                    currentInterval = nextInterval;
                }
            }

            result.Add(currentInterval);

            return [.. result];
        }
    }
}
