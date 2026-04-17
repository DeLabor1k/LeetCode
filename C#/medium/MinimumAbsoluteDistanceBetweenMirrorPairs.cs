public class Solution 
{
    // Task 3761 | Medium
    public int MinMirrorPairDistance(int[] nums) 
    {
        Dictionary<int, int> lastSeen = new Dictionary<int, int>();
        int minDistance = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int currentNumber = nums[i];
            int reversed = ReverseNumber(currentNumber);

            if (lastSeen.ContainsKey(currentNumber))
            {
                int previousIndex = lastSeen[currentNumber];
                int distance = i - previousIndex;

                if (distance < minDistance)
                {
                    minDistance = distance;
                }
            }
            lastSeen[reversed] = i;
        }
        
        return minDistance == int.MaxValue ? -1 : minDistance;   
    }
    
    private int ReverseNumber(int x)
    {
        int result = 0;
        
        while (x > 0)
        {
            result = result * 10 + x % 10;
            x = x / 10;
        }
        
        return result;
    }
}