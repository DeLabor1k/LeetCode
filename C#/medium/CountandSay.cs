public class Solution 
{
    // Task 38 | Medium
    public string CountAndSay(int n) 
    {
        if (n == 1) return "1";
        
        string result = "1";
        
        for (int i = 2; i <= n; i++) 
        {
            result = GetNextSequence(result);
        }
        
        return result;
    }
    
    private string GetNextSequence(string s) 
    {
        StringBuilder sb = new StringBuilder();
        int count = 1;
        
        for (int i = 0; i < s.Length; i++) 
        {
            if (i + 1 < s.Length && s[i] == s[i + 1]) 
            {
                count++;
            }
            else 
            {
                sb.Append(count);
                sb.Append(s[i]);
                count = 1;
            }
        }
        
        return sb.ToString();
    }
}