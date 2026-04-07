public class Solution 
{
    // Task 69 | Easy
    public int MySqrt(int x) 
    {
        int left = 0;
        int right = x;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            long square = (long)mid * mid;
            if (square == x)
            {
                return mid;
            }
            else if (square < x)
            {
                left = mid + 1;
            }
            else 
            {
                right = mid - 1;
            }
        }
    return right;
    }
}