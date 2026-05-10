public class Solution 
{
    // Task 1914 | Medium
    public int[][] RotateGrid(int[][] grid, int k) 
    {
        int m = grid.Length;
        int n = grid[0].Length;
        
        int layers = Math.Min(m, n) / 2;
        
        for (int layer = 0; layer < layers; layer++) 
        {
            int top = layer;
            int bottom = m - 1 - layer;
            int left = layer;
            int right = n - 1 - layer;
            
            int perimeter = 2 * (bottom - top + 1) + 2 * (right - left + 1) - 4;
            int rotations = k % perimeter;
            
            for (int r = 0; r < rotations; r++) 
            {
                int temp = grid[top][left];
                
                for (int j = left; j < right; j++) 
                {
                    grid[top][j] = grid[top][j + 1];
                }
                
                for (int i = top; i < bottom; i++) 
                {
                    grid[i][right] = grid[i + 1][right];
                }
                
                for (int j = right; j > left; j--) 
                {
                    grid[bottom][j] = grid[bottom][j - 1];
                }
                
                for (int i = bottom; i > top + 1; i--) 
                {
                    grid[i][left] = grid[i - 1][left];
                }
                
                grid[top + 1][left] = temp;
            }
        }
        
        return grid;
    }
}