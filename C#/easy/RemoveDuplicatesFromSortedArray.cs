public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        // Task 26 | Easy

        if (nums == null || nums.Length == 0) return 0;

        int insertPosition = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i-1])
            {
                nums[insertPosition] = nums[i];
                insertPosition++;
            }
        }
        return insertPosition;
    }
}