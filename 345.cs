//345 Reverse vowels in string
public class Solution {
    public string ReverseVowels(string s) {
        char[] CharacterInS = s.ToCharArray();
        char[] Vowels = ['a', 'e', 'i', 'o', 'u'];
        List<char> FoundVowels = new List<char>();
        List<int> IndexOfVowels = new List<int>(); 
        for (int c = 0; c < CharacterInS.Length; c++) {
            if (Vowels.Contains(char.ToLower(CharacterInS[c]))) {
                FoundVowels.Add(CharacterInS[c]);
                IndexOfVowels.Add(c);
            }
        }
        FoundVowels.Reverse();

        for (int i = 0; i < IndexOfVowels.Count; i++)
        {
            CharacterInS[IndexOfVowels[i]] = FoundVowels[i];
        }
        return new string(CharacterInS);
    }
}
//Runtime 19ms