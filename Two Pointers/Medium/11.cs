//11. Container with most water
public class Solution {
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length -1;
        int ht = 0, width = 0, maxarea = 0, area = 0;

        while (left != right) {
            ht = Math.Min(height[left], height[right]);
            width = right - left;
            area = ht * width;

            if (area > maxarea)
                maxarea = area;

            if (height[left] < height[right])
                left = left + 1;
            else 
                right = right -1;
        }
        return maxarea;
    }
}