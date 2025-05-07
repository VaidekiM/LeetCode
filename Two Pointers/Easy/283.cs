//283 Move 0's

public class Solution {
    public void MoveZeroes(int[] nums) {
        int lastNonZeroIndex = 0;
        int buffer = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                buffer = nums[i];
                nums[i] = nums[lastNonZeroIndex];
                nums[lastNonZeroIndex] = buffer;
                lastNonZeroIndex++;
            }
        }
    }
}