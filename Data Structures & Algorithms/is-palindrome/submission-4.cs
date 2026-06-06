public class Solution {
    public bool IsPalindrome(string s) {
        var cleaned = s.Where(char.IsLetterOrDigit).Select(char.ToLower);

        return cleaned.SequenceEqual(cleaned.Reverse());
    }
}
