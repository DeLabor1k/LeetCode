public class Solution 
{
    // Task 41 | Hard
    public int FirstMissingPositive(int[] nums) 
    {
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            while (nums[i] >= 1 && nums[i] <= n && nums[i] != nums[nums[i] - 1])
            {
                int temp = nums[i];
                nums[i] = nums[temp - 1];
                nums[temp - 1] = temp;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }
        return n + 1;
    }
}