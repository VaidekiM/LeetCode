//1. Two Sum
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        //O(n^2) approach

        /*for (int i = 0; i < nums.Length; i++){
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[j] + nums[i] == target) {
                    return new int[] {i, j};
                }
            }
        }
        return new int[2];*/
        /*--------------------------------------------------*/
        
        //O(n) approach
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            int complement = target - nums[i];
            if (map.ContainsKey(complement)) {
                return new int[2] {map[complement], i};
            }
            if (!map.ContainsKey(nums[i])) {
                map[nums[i]] = i;
            }
        }
        return new int[2];
    }
}