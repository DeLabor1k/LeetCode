public class Solution 
{   
    // Task 6 | Medium
    public string Convert(string s, int numRows) 
    {
        if (numRows == 1 || numRows >= s.Length) return s;

        StringBuilder[] rows = new StringBuilder[numRows];

        for (int i = 0; i < numRows; i++)
        {
            rows[i] = new StringBuilder();
        }

        int currentRow = 0;
        bool goingDown = false;

        for (int i = 0; i < s.Length; i++)
        {
            rows[currentRow].Append(s[i]);

            if (currentRow == 0)
            {
                goingDown = true;
            }
            else if (currentRow == numRows - 1)
            {
                goingDown = false;
            }

            currentRow += goingDown ? 1 : -1;
        }
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < numRows; i++)
        {
            result.Append(rows[i]);
        }
        return result.ToString();

    }
}