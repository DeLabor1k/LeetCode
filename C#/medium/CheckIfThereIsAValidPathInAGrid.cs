public class Solution 
{
    // Task 1391 | Medium
    public bool HasValidPath(int[][] grid) 
    {
        int m = grid.Length;
        int n = grid[0].Length;
        
        bool[][] dirs = new bool[7][];
        dirs[1] = new bool[] { false, true, false, true };
        dirs[2] = new bool[] { true, false, true, false }; 
        dirs[3] = new bool[] { false, false, true, true };  
        dirs[4] = new bool[] { false, true, true, false };   
        dirs[5] = new bool[] { true, false, false, true };   
        dirs[6] = new bool[] { true, true, false, false };

        int[] dRow = { -1, 0, 1, 0 }; 
        int[] dCol = { 0, 1, 0, -1 };

        Queue<(int, int)> queue = new Queue<(int, int)>();
        bool[,] visited = new bool[m, n];
        queue.Enqueue((0, 0));
        visited[0, 0] = true;

        while (queue.Count > 0)
        {
            var (r, c) = queue.Dequeue();
            if (r == m - 1 && c == n - 1) return true;
    
            for (int d = 0; d < 4; d++)
            {
                int nr = r + dRow[d];
                int nc = c + dCol[d];
        
                if (nr >= 0 && nr < m && nc >= 0 && nc < n && !visited[nr, nc])
                {
                    if (CanConnect(dirs, grid[r][c], grid[nr][nc], d))
                    {
                        visited[nr, nc] = true;
                        queue.Enqueue((nr, nc));
                    }
                }
            }
        }
        return false;
    }
    
    private bool CanConnect(bool[][] dirs, int fromType, int toType, int dir)
    {
        int oppositeDir = (dir + 2) % 4;
        return dirs[fromType][dir] && dirs[toType][oppositeDir];
    }
}