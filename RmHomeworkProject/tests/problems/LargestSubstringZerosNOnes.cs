using System;

using NUnit.Framework;

/*
 * You are given a string  of length . Each character of the string is either 0 or 1. 
 * Now, you need to select the largest substring in which the count of 0 in the string 
 * is more than the count of 1. Print the maximum possible length of the subarray in the output.
 */
namespace RmHomeworkProject.tests.problems {

    //https://www.hackerearth.com/practice/algorithms/searching/binary-search/practice-problems/algorithm/flipping-the-string-831bbbbe/
    class LargestSubstringZerosNOnes {
        private int[] ZerosCountCumulative, OnesCountCumulative;

        [Test]
        public void TestZerosOnes() {
            string s = "10110001010110"; 
            string longestSubstring = getLongestSubstringZerosAndOnes(s);
            Assert.AreEqual("0110001010110", longestSubstring);

            s = "011100"; 
            longestSubstring = getLongestSubstringZerosAndOnes(s);
            Assert.AreEqual("100", longestSubstring);

            s = "1110001001010100100111001100000111000100101111001011101010100111111111101110010000110001011001010101101011110110100110111001101011101110000011110101110000110010010101001001110100010110111011010010010110000000100111110010111110111110011001011001010011010001001010011111000000101111010010100000001001101001010001100100100000010110001101111111000010000001000101101000011100000001";
            longestSubstring = getLongestSubstringZerosAndOnes(s);
            Assert.AreEqual(376, longestSubstring.Length);
        }
        /*
                 * Algo:
                 * Go thru and store cumulative 0, 1 counts in ZeroCumulative and OneCumumative arrays
                 * Similar to MaxSlice, Grouping
                 * 
                 * The start reading each int
                 * In a Map, store List<MyString> objects { private string _finalSubstring, Map char => count } 
                 * If count > 1 start a new MyString
                 * .
                 *  * At the end, compare all the _finalSubstring objects.
                 *  .
                 * Optimizn: track the maxlen MyString so we don't need to go thru all the objects again.
                 * .

                 */
        public string getLongestSubstringZerosAndOnes(string A) {
            StoreCumulativeOf(A);
            string longestSubstring = "";
            int numZeros = 0;
            int numOnes = 0;
            for (int p = 0; p < A.Length; p++) {
                for (int q = p + 1; q < A.Length; q++) {
                    numZeros = ZerosCountCumulative[q] - ZerosCountCumulative[p];
                    numOnes = OnesCountCumulative[q] - OnesCountCumulative[p];
                    if (numZeros > numOnes) {
                        string nextStr = A.Substring(p + 1, (q - p));
                        if ((q - p) > longestSubstring.Length) longestSubstring = nextStr;
                    }
                }
            }

            return longestSubstring;
        }

        private void StoreCumulativeOf(string A) {
            ZerosCountCumulative = new int[A.Length];
            OnesCountCumulative = new int[A.Length];

            int totalZeros = 0;
            int totalOnes = 0;

            for (int i = 0; i < A.Length; i++) {
                int n = Convert.ToInt32(A.Substring(i, 1));
                if (n == 0) {
                    ZerosCountCumulative[i] = ++totalZeros;
                    OnesCountCumulative[i] = totalOnes;
                }
                else {
                    ZerosCountCumulative[i] = totalZeros;
                    totalOnes = totalOnes + 1;
                    OnesCountCumulative[i] = totalOnes;
                }
            }
        }
    }
}
