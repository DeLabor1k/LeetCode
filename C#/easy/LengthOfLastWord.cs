public class Solution 
{
    // Task 58 | Easy
    public int LengthOfLastWord(string s) 
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        int length = 0;
        bool count = false;

        for (int i = 0; i < reversed.Length; i++)
        {
            if (reversed[i] != ' ') 
            {
                count = true;
                length++;
            } 
            else if (count)
            {
                return length;
            }
        }
        return length;
    }
}