//1431 Kids with the greatest number of candies
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> Output = new List<bool>();
        int max = 0;
        //candies.Max();
        foreach(int n in candies)
        {
            if (n > max)
                max = n;
        }

        foreach (var candy in candies) {
            Output.Add((candy+ extraCandies) >= max);
        }
        return Output;
    }
}
//Runtime: 1ms