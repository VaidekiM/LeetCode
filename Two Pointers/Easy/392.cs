//392. Is Subsequence
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i = 0, j = 0;
        if (s.Length == 0)
            return true;
        else {
            while (i < s.Length && j < t.Length) {
                if (s[i] == t[j]) {
                    i++;
                    j++;
                }
                else {
                    j++;
                }
            }
        }
        return (i == s.Length)? true : false;
    }
}