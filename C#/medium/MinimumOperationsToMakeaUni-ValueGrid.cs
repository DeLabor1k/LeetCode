public class Solution 
{
    // Task 2033 | Medium
    public int MinOperations(int[][] grid, int x) 
    {
        int m = grid.Length;
        int n = grid[0].Length;
        List<int> arr = new List<int>(m * n);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr.Add(grid[i][j]);
            }
        }
        int remainder = arr[0] % x;
        foreach (int val in arr)
        {
            if (val % x != remainder)
            return -1;
        }
        arr.Sort();
        int median = arr[arr.Count / 2];
        int operation = 0;
        
        foreach (int val in arr)
        {
            operation += Math.Abs(val - median) / x;
        }
        return operation;
    }
}