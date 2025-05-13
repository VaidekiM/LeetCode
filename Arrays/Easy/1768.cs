//1768. Merge Strings Alternatively

/*public class Solution {
    public string MergeAlternately(string word1, string word2) {
        String MergedOutputString = "";
        int MaxLength = Math.Max(word1.Length, word2.Length);
        for (int i = 0; i< MaxLength; i++){
            if (i < word1.Length)
                MergedOutputString = MergedOutputString + word1[i];
            if (i < word2.Length)
                MergedOutputString = MergedOutputString + word2[i];
        }
        return MergedOutputString;
    }
}*/

//Improved Runtime
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int len1 = word1.Length, len2 = word2.Length;
        StringBuilder mergedOutput = new StringBuilder(len1 + len2);
        int maxLength = Math.Max(len1, len2);

        for (int i = 0; i < maxLength; i++) {
            if (i < word1.Length)
                mergedOutput.Append(word1[i]);
            if (i < word2.Length)
                mergedOutput.Append(word2[i]);
        }

        return mergedOutput.ToString();
    }
}