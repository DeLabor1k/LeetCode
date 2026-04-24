public class Solution 
{
    // Task 2833 | Easy
    public int FurthestDistanceFromOrigin(string moves) 
    {
        int countL = 0, countR = 0, count_ = 0;
        
        // Считаем количество L, R и _
        foreach (char c in moves)
        {
            if (c == 'L') countL++;
            else if (c == 'R') countR++;
            else count_++;
        }
        
        // Определяем, в какую сторону направить все '_'
        char replaceChar = (countL >= countR) ? 'L' : 'R';
        
        // Считаем позицию с учётом замены
        int position = 0;
        foreach (char c in moves)
        {
            char actual = (c == '_') ? replaceChar : c;
            
            if (actual == 'L')
                position--;
            else
                position++;
        }
        
        return Math.Abs(position);
    }
}