public class Solution 
{
    // Task 190 | Easy
    public int ReverseBits(int n) 
	{
            string bin = "";
            if(n == 0)
                return 0;
            else
            {
                while (n > 0)
                {
                    bin = (n % 2).ToString() + bin;
                    n /= 2;
                }
                if(bin.Length < 32)
                {
                    bin = bin.PadLeft(32, '0');
                }
                char[] chars = bin.ToCharArray();
                Array.Reverse(chars);
                bin = new string(chars);
 
                uint ten = Convert.ToUInt32(bin, 2);
                return (int)ten;
                
            }
        }
    }