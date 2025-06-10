//2215. Find the difference of 2 arrays

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> Arr1 = new (nums1);
        HashSet<int> Arr2 = new (nums2);

        List<int> Out1 = [];
        List<int> Out2 = [];

        foreach (int num in nums1){
            if (!Arr2.Contains(num) && !Out1.Contains(num))
                Out1.Add(num);
        }

        foreach (int num in nums2){
            if (!Arr1.Contains(num) && !Out2.Contains(num))
                Out2.Add(num);
        }
        return [Out1, Out2];
    }
}