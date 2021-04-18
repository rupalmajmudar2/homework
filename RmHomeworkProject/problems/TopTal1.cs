using System;
using System.Collections.Generic;
using System.Text;

namespace RmHomeworkProject.problems {

    class Result {

        /*
         * Complete the 'countPalindromes' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int countPalindromes(string s) {
            if (string.IsNullOrEmpty(s)) return 0;
            s = s.Trim();
            int count = 0; // s.Length; //1-char

            string all = "";
            for (int i = 0; i < s.Length; i++) {
                for (int j=1; j <= s.Length - i; j++) {
                    try {
                        string substr = s.Substring(i, j);
                        if (IsPalindrome(substr)) {
                            count++;
                            all += substr + ";";
                        }
                    }
                    catch (Exception e) {
                        Console.WriteLine("Err");
                    }
                }
            }

            return count;
        }

        public static bool IsPalindrome(string s) {
            string s_reverse = "";
            for (int i = s.Length - 1; i >= 0; i--) {
                s_reverse += s[i].ToString();
            }

            return s_reverse.Equals(s);
        }

    }
}
