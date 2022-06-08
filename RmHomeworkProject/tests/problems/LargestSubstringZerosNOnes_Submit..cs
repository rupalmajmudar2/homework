using System;

//https://www.hackerearth.com/practice/algorithms/searching/binary-search/practice-problems/algorithm/flipping-the-string-831bbbbe/
class LargestSubstringZerosNOnes_Submit {
    public static void Main() {
        int N = int.Parse(Console.ReadLine());
        string S = Console.ReadLine();
        string longest = getLongestSubstringZerosAndOnes(S);
        Console.WriteLine(longest.Length);
    }

    public static string getLongestSubstringZerosAndOnes(string A) {
        int[] ZerosCountCumulative = new int[A.Length];
        int[] OnesCountCumulative = new int[A.Length];

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
}
