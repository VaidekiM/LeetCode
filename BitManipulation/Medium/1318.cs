//1318.Minimum flips to make a OR b equal c
public class Solution {
    public int MinFlips(int a, int b, int c) {
        string binary_a = Convert.ToString(a, 2);
        string binary_b = Convert.ToString(b, 2);
        string binary_c = Convert.ToString(c, 2);
        int maxLength = Math.Max(binary_a.Length, Math.Max(binary_b.Length,binary_c.Length));

        int flip_counter = 0;
        binary_a = binary_a.PadLeft(maxLength, '0');
        binary_b = binary_b.PadLeft(maxLength, '0');
        binary_c = binary_c.PadLeft(maxLength, '0');
        
        for (int i = 0; i < maxLength; i++) {
            if (binary_c[i] == '1') {
                if (binary_a[i] == '0' && binary_b[i] == '0') {
                    flip_counter++;
                }
            }
            else {
                if (binary_a[i] == '1') {
                    flip_counter++;
                }
                if (binary_b[i] == '1') {
                    flip_counter++;
                }
            }
        }
        return flip_counter;
    }
}