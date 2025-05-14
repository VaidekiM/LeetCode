//151. Reverse words in a string
public class Solution {
    public string ReverseWords(string s) {
        string[] WordsArray = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(WordsArray);
        return string.Join(" ", WordsArray);
    }
}