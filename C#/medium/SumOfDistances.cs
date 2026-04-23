public class Solution 
{
    // Task 2615 | Medium
    public long[] Distance(int[] nums) 
    {
        Dictionary<int, List<int>> groups = new Dictionary<int, List<int>>();
        long[] arr = new long[nums.Length];

        for (int i = 0; i < nums.Length;i++)
        {
            if (!groups.ContainsKey(nums[i]))
            {
                groups[nums[i]] = new List<int>();
            }
            groups[nums[i]].Add(i);
        }
        foreach (var indices in groups.Values)
        {
            if (indices.Count == 1)
            {
                arr[indices[0]] = 0;
                continue;
            }
        
            long totalSum = 0;
            foreach (int idx in indices)
            {
                totalSum += idx;
            }       

            long leftSum = 0;
            int count = indices.Count;

            for (int k = 0; k < count;k++)
            {
                int idx = indices[k];
                long rightSum = totalSum - leftSum - idx;

                arr[idx] = (idx * (long)k - leftSum) + (rightSum - idx * (long)(count - k - 1 ));

                leftSum += idx;
            }
        }
        return arr;
    }
}