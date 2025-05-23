//33. Search in rotated sorted array
public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length -1;
        int mid = 0;
        while (left <= right) {
            mid = (left + right)/2;
            if (nums[mid] == target)
                return mid;
            
            if (nums[left] <= nums[mid]) {
                if (nums[left] <= target && target < nums[mid]) 
                    right = mid - 1;
                else 
                    left = mid + 1;
            }
            else {
                if (nums[mid] < target && target <= nums[right])
                    left = mid + 1;
                else 
                    right = mid - 1;
            }
        }
        return -1;
    }
}