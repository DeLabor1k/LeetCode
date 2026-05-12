public class Solution 
{
    // Task 1665 | Hard
    public int MinimumEffort(int[][] tasks) 
    {
        Array.Sort(tasks, (a, b) => (b[1] - b[0]).CompareTo(a[1] - a[0]));
        
        int energy = 0;
        int current = 0;
        
        for (int i = 0; i < tasks.Length; i++) 
        {
            int actual = tasks[i][0];
            int minimum = tasks[i][1];
            
            if (current < minimum) 
            {
                energy += minimum - current;
                current = minimum;
            }
            
            current -= actual;
        }
        
        return energy;
    }
}