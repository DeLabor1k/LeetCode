public class Solution 
{
    // Task 11 | Medium
    public int MaxArea(int[] height) 
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int currentHeight = Math.Min(height[left], height[right]);
            int width = right - left;
            int area = currentHeight * width;

            maxArea = Math.Max(maxArea, area);
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxArea;
    }
}