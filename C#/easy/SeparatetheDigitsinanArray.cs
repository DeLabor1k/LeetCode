public class Solution 
{
    // Task 2553 | Easy
    public int[] SeparateDigits(int[] nums) 
    {
        List<int> result = new List<int>();
        
        for (int i = 0; i < nums.Length; i++) 
        {
            string numStr = nums[i].ToString();
            for (int j = 0; j < numStr.Length; j++) 
            {
                result.Add(numStr[j] - '0');
            }
        }
        
        return result.ToArray();
    }
}