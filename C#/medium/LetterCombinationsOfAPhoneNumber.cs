public class Solution 
{
    // Task 17 | Medium
    private readonly string[] _mapping = {
        "",     // 0
        "",     // 1
        "abc",  // 2
        "def",  // 3
        "ghi",  // 4
        "jkl",  // 5
        "mno",  // 6
        "pqrs", // 7
        "tuv",  // 8
        "wxyz"  // 9
    };
    
    public IList<string> LetterCombinations(string digits) {
        var result = new List<string>();
        
        if (string.IsNullOrEmpty(digits)) {
            return result;
        }
        
        Backtrack(result, digits, 0, new StringBuilder());
        return result;
    }
    private void Backtrack(IList<string> result, string digits, int index, StringBuilder current) {
        // Если дошли до конца строки
        if (index == digits.Length) {
            result.Add(current.ToString());
            return;
        }
        // Буквы для текущей цифры
        int digit = digits[index] - '0';
        string letters = _mapping[digit];
        
        // Перебираем все возможные буквы для этой цифры
        for (int i = 0; i < letters.Length; i++) {
            current.Append(letters[i]);
            Backtrack(result, digits, index + 1, current);
            current.Remove(current.Length - 1, 1);
        }
    }
}