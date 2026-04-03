public class Solution 
{
    // Task 28 | Easy
    public int StrStr(string haystack, string needle) 
    {
        int hLen = haystack.Length;
        int nLen = needle.Length;
        
        if (nLen > hLen) return -1;

        for (int i = 0; i <= hLen - nLen; i++)
        {
            bool found = true;
            for (int j = 0; j < nLen; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    found = false;
                    break;
                }
            }
            
            if (found) return i;
        }
        
        return -1;
    }
}