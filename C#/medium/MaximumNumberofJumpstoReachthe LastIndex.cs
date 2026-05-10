public class Solution 
{
    // Task 2770 | Medium
    public int MaximumJumps(int[] nums, int target) 
    {
        int n = nums.Length;
        int[] dp = new int[n];
        
        for (int i = 0; i < n; i++) 
        {
            dp[i] = -1;
        }
        
        dp[0] = 0;
        
        for (int i = 0; i < n; i++) 
        {
            if (dp[i] == -1) continue;
            
            for (int j = i + 1; j < n; j++) 
            {
                long diff = (long)nums[j] - (long)nums[i];
                if (diff >= -target && diff <= target) 
                {
                    dp[j] = Math.Max(dp[j], dp[i] + 1);
                }
            }
        }
        
        return dp[n - 1];
    }
}