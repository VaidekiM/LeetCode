//1207. Unique number of occurrences

public class Solution {
    public bool UniqueOccurrences(int[] arr) {

        if(arr.Length == 1)
            return true;
            
        var freqMap = new Dictionary<int, int>();
        foreach (int num in arr) {
            if (freqMap.ContainsKey(num))
                freqMap[num]++;
            else
                freqMap[num] = 1;
        }

        // Check if frequency counts are unique
        var freqValues = freqMap.Values;
        var uniqueFreqs = new HashSet<int>(freqValues);

        return freqValues.Count() == uniqueFreqs.Count;
    }
}