//643. Maximum Average Subarray I
public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        var Sum = 0;
        for (int i = 0; i < k; i++)
        {
            Sum += nums[i];
        }

        var Max = (double)Sum/k;
        for (int i = k; i < nums.Length; i++){
            Sum += nums[i] - nums[i - k];
            Max = Math.Max(Max, (double)Sum/k);
        }
        return Max;
    }
}