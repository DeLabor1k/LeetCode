public class Solution 
{
    // Task 396 | Medium
    public int MaxRotateFunction(int[] nums) 
    {
        int n = nums.Length;

        if (n <= 1) return 0;

        long f = 0;
        long sum = 0;
        
        for (int i = 0; i < n; i++) {
            f += (long)i * nums[i];
            sum += nums[i];
        }
        
        long maxF = f;
        
        for (int k = 1; k < n; k++) {
            f = f + sum - (long)n * nums[n - k];
            maxF = Math.Max(maxF, f);
        }
        return (int)maxF;
    }
}