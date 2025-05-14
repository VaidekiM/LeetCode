//334. Increasing Triplet Sequence

public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int First = int.MaxValue;
        int Second = int.MaxValue;

        foreach (var n in nums) {
            if (n <= First)
                First = n;
            else if (n <= Second) 
                Second = n;
            else 
                return true;
        }
        return false;
    }
}