/*
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        List<int> IndexAvailableForPlanting = new List<int>();
        if (n != 0) {
            if (flowerbed[0] == 1) {
                //Even case
                for (int i = 2; i < flowerbed.Length; i++) {
                    if (i%2 == 0) {
                        if (flowerbed[i] != 1)
                            IndexAvailableForPlanting.Add(1);
                    }
                }
            }
            else {
                //Odd case
                for (int i = 1; i < flowerbed.Length; i++) {
                    if (i%2 != 0) {
                        if (flowerbed[i] != 1)
                            IndexAvailableForPlanting.Add(1);
                    }
                }
            }
        }
        if (IndexAvailableForPlanting.Count() == n || n == 0)
            return true;
        else 
            return false;
    }
}
*/

//
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
       int count = 0;
        for (int i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 0 &&
                (i == 0 || flowerbed[i - 1] == 0) &&
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) {
                
                flowerbed[i] = 1;
                count++; 
                //Added this to improve the run time: Runtime improved 100% from previous version
                if (count >= n) return true;
                i++;
            }
        }
        return count >= n;

    }
}