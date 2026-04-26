public class Solution 
{
    // Task 1559 | Medium
    public bool ContainsCycle(char[][] grid) 
    {
        int m = grid.Length;
        int n = grid[0].Length;
        bool[,] visited = new bool[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!visited[i, j])
                {
                    if (DFS(grid, i, j, -1, -1, grid[i][j], visited, m, n))
                        return true;
                }
            }
        }
        return false;
    }
    private  bool DFS (char[][] grid, int row, int col, int parentRow, int parentCol, char c, bool[,] visited, int m, int n)
    {
        if (row < 0 || row >= m || col < 0 || col >= n) return false;
        if (grid[row][col] != c) return false;
        if (visited[row, col]) return true;

        visited[row, col] = true;

        int[] dRow = {-1, 1, 0, 0}; 
        int[] dCol = {0, 0, -1, 1};

        for (int d = 0; d < 4; d++)
        {
            int newRow = row + dRow[d];
            int newCol = col + dCol[d];
            if (newRow == parentRow && newCol == parentCol) continue;

            if (DFS(grid,newRow, newCol, row, col, c ,visited, m, n))
            return true;
        }
        return false;
    }
}