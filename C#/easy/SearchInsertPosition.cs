public class Solution 
{
    // Task 35 | Easy
    public int SearchInsert(int[] nums, int target) 
    {

        if (nums == null || nums.Length == 0) return 0;

        int left = 0;
        int right = nums.Length - 1;
        int mid = 0;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
    }
}