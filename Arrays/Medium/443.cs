//443 String Compression

// public class Solution {
//     public int Compress(char[] chars) {
//         int Counter = 1;  // Start with 1 because the first character is already counted
//         List<char> OutputArray = new List<char>();
        
//         for (int i = 0; i < chars.Length; i++) {
//             // Check if we are at the last character or if the next character is different
//             if (i + 1 == chars.Length || chars[i] != chars[i + 1]) {
//                 // Add the current character to the OutputArray
//                 OutputArray.Add(chars[i]);
                
//                 // If the count is greater than 1, add the count as a number
//                 if (Counter > 1) {
//                     foreach (var digit in Counter.ToString()) {
//                         OutputArray.Add(digit);  // Add the count directly as a string
//                     }
//                 }
                
//                 // Reset the Counter for the next character
//                 Counter = 1;
//             } else {
//                 // If the next character is the same, increment the Counter
//                 Counter++;
//             }
//         }
        
//         // Copy the result into the original array
//         for (int i = 0; i < OutputArray.Count; i++) {
//             chars[i] = OutputArray[i];
//         }

//         return OutputArray.Count;
//     }
// }

//Optimized Approach

public class Solution {
    public int Compress(char[] chars) {
        int writeIndex = 0;  // Pointer to write the result in the array
        int i = 0;           // Pointer to read the input array

        while (i < chars.Length) {
            char currentChar = chars[i];
            int count = 1;

            // Count the number of consecutive characters
            while (i + 1 < chars.Length && chars[i] == chars[i + 1]) {
                i++;
                count++;
            }

            // Write the current character
            chars[writeIndex++] = currentChar;

            // If the character appears more than once, write the count
            if (count > 1) {
                foreach (var digit in count.ToString()) {
                    chars[writeIndex++] = digit;  // Write each digit of the count
                }
            }

            // Move to the next different character
            i++;
        }

        return writeIndex;  // Return the new length of the array
    }
}

