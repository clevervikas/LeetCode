//Given a string s, return the length of the longest substring between two equal characters, excluding the two characters. If there is no such substring return -1.

// A substring is a contiguous sequence of characters within a string.

 

// Example 1:

// Input: s = "aa"
// Output: 0
// Explanation: The optimal substring here is an empty substring between the two 'a's.
// Example 2:

// Input: s = "abca"
// Output: 2
// Explanation: The optimal substring here is "bc".
// Example 3:

// Input: s = "cbzxy"
// Output: -1
// Explanation: There are no characters that appear twice in s.
public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int result = -1;

                for (int row = 0; row < s.Length; row++)
                {
                    for (int col = row + 1; col < s.Length; col++)
                    {
                        if (s[row].ToString() == s[col].ToString())
                        {
                            result = Math.Max(result, (col - row) - 1);
                        }
                    }

                }
                return result;       
        }
    }
