public class Solution 
{
    // Task 27 | Easy
    public int RemoveElement(int[] nums, int val) 
    {
        if (nums == null || nums.Length == 0) return 0;

        int firstPos = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[firstPos] = nums[i];
                firstPos++;
            }
        }
        return firstPos;
    }   
}