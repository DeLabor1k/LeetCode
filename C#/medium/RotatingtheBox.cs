public class Solution 
{
    // Task 1861 | Medium
    public char[][] RotateTheBox(char[][] boxGrid) 
    {
        int m = boxGrid.Length;
        int n = boxGrid[0].Length;
        
        char[][] result = new char[n][];
        for (int i = 0; i < n; i++) 
        {
            result[i] = new char[m];
        }
        
        for (int i = 0; i < m; i++) 
        {
            int bottom = n - 1;
            for (int j = n - 1; j >= 0; j--) 
            {
                if (boxGrid[i][j] == '#') 
                {
                    result[bottom][m - 1 - i] = '#';
                    bottom--;
                } 
                else if (boxGrid[i][j] == '*') 
                {
                    result[j][m - 1 - i] = '*';
                    bottom = j - 1;
                }
            }
            
            while (bottom >= 0) 
            {
                result[bottom][m - 1 - i] = '.';
                bottom--;
            }
        }
        
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < m; j++) 
            {
                if (result[i][j] != '#' && result[i][j] != '*') 
                {
                    result[i][j] = '.';
                }
            }
        }
        
        return result;
    }
}