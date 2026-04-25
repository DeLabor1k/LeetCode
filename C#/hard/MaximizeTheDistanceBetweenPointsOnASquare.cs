public class Solution 
{
    // Task 3464 | Hard
    public int MaxDistance(int side, int[][] points, int k) 
    {
        long perimetr = 4L * side;
        int low = 1, high = 2 * side;

        while (low < high)
        {
            int mid = (low + high + 1) / 2;
            if (CanSelect(points, k, side, mid, perimetr))
                low = mid;
            else
                high = mid - 1;
        }
    return low;
    }

    private long GetPosition(int x, int y, int side)
    {
        if (y == 0) return x;
        if (x == side) return side + y;
        if (y == side) return 3L * side - x;
        return 4L * side - y;
    }

    private bool CanSelect(int[][] points, int k, int side, int D, long perimetr)
    {
        int n = points.Length;
        if (k == 1) return true;

        long[] pos = new long[n];
        for (int i = 0; i < n; i++)
        {
            pos[i] = GetPosition(points[i][0], points[i][1], side);
        }
        Array.Sort(pos);

        long[] pos2 = new long[2 * n];
        for (int i = 0; i < n; i++)
        {
            pos2[i] = pos[i];
            pos2[i + n] = pos[i] + perimetr;
        }

        int[] next = new int[2 * n];
        int ptr = 0;
        for (int i = 0; i < 2 * n; i++)
        {
            while (ptr < 2 * n && pos2[ptr] - pos2[i] < D)
                ptr++;
            next[i] = ptr;
        }

        for (int start = 0; start < n; start++)
        {
            int current = start;
            int count = 1;

            while (count < k && next[current] < start + n)
            {
                current = next[current];
                count++;
            }

            if (count >= k && pos2[start] + perimetr - pos2[current] >= D)
                return true;
        }
        return false;
    }
}