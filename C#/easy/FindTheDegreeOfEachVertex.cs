public class Solution 
{
    // Task 3898 | Easy
    public int[] FindDegrees(int[][] matrix) 
    {
        int n = matrix.Length;
        int[] ans = new int[n];
        
        for (int i = 0; i < n; i++) {
            int degree = 0;
            for (int j = 0; j < n; j++) {
                degree += matrix[i][j];
            }
            ans[i] = degree;
        }
        
        return ans;
    }
}