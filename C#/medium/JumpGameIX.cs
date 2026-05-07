public class Solution 
{
    // Task 3660 | Medium
    public int[] MaxValue(int[] nums) 
    {
        int n = nums.Length;
        
        int[] suffixMin = new int[n + 1];
        suffixMin[n] = int.MaxValue;
        for (int i = n - 1; i >= 0; i--) 
        {
            suffixMin[i] = Math.Min(nums[i], suffixMin[i + 1]);
        }
        
        int[] ans = new int[n];
        int l = 0;
        
        while (l < n) 
        {
            int r = l;
            int componentMax = nums[l];
            
            while (r + 1 < n && componentMax > suffixMin[r + 1]) 
            {
                r++;
                componentMax = Math.Max(componentMax, nums[r]);
            }
            
            for (int i = l; i <= r; i++) 
            {
                ans[i] = componentMax;
            }
            
            l = r + 1;
        }
        
        return ans;
    }
}