public class Solution {
    // task №9
    public bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }
        int reversed = 0;
        int i = x;
        while (i != 0) {
            reversed = reversed * 10 + i % 10;
            i /= 10;
        }
        return x == reversed;
    }
}