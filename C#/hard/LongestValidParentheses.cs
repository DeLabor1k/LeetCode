public class Solution 
{
    // Task 32 | Hard
    public int LongestValidParentheses(string s) 
    {
        Stack<int> storage = new Stack<int>();
        storage.Push(-1);
        int maxLen = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') storage.Push(i);
            if (s[i] == ')')
            {
                storage.Pop();
                if (storage.Count > 0)
                {
                    int len = i - storage.Peek();
                    maxLen = Math.Max(maxLen, len);
                }
                else storage.Push(i);
            }
        }
        return maxLen;
    }
}