//1679. Max number of K-sum pairs

public class Solution {
    public int MaxOperations(int[] nums, int k) {
        int firstPtr = 0;
        int lastValuePtr = nums.Length - 1;
        int counter = 0;
        int sum = 0;
        Array.Sort(nums);
        while (firstPtr < lastValuePtr ) {
            sum = nums[firstPtr] + nums[lastValuePtr];
            if (sum == k) {
                firstPtr++;
                lastValuePtr--;
                counter++;
            }
            else if (sum < k){
                firstPtr++;
            } 
            else {
                lastValuePtr--;
            }
        }
        return counter;
    }
}