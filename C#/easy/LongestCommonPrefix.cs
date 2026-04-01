public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        // Task 14

        if (strs.Length == 0 || string.IsNullOrEmpty(strs[0])) return "";

        for (int j = 0; j < strs[0].Length; j++)
        {
            for (int i = 1; i < strs.Length; i++)
            {
                if (j >= strs[i].Length || strs[i][j] != strs[0][j])
                {
                    return strs[0].Substring(0, j);
                }
            }
        } return strs[0];
    }
}