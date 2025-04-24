/*public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++) {
            output[i] = RecursiveProduct(nums, 0, i);
        }

        return output;
    }
    private int RecursiveProduct(int[] nums, int currentIndex, int skipIndex) {
        if (currentIndex >= nums.Length) {
            return 1;
        }

        if (currentIndex == skipIndex) {
            return RecursiveProduct(nums, currentIndex + 1, skipIndex);
        }

        return nums[currentIndex] * RecursiveProduct(nums, currentIndex + 1, skipIndex);
    }
}*/

//
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        int num = 1;

        for(int i=0; i < nums.Length; i++)
        {
            output[i] = num;
            num *= nums[i];
        }
        num = 1;

        for(int i = nums.Length-1; i >= 0; i--)
        {
            output[i] *= num;
            num *= nums[i];
        }
        return output;
    }
}