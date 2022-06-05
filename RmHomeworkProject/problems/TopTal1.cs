using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            List<string> table = new List<string>();

            for (int i = 0; i < s.Length; i++) {
                //Need to handle even and odd sepatately!
                find(s, i, i, table);
                find(s, i, i + 1, table);
            }


            /*if (string.IsNullOrEmpty(s)) return 0;
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
            }*/

            return table.Count;
        }

        public static void find(String s, int low, int high, List<string> table) {
            try {
                while (low >= 0 && high < s.Length
                        && s.ElementAt(low).Equals(s.ElementAt(high))) {

                    string substr = s.Substring(low, high+1);
                    if (string.IsNullOrEmpty(substr) == false) {
                        table.Add(substr);
                    }

                    // Expand in both directions
                    low--;
                    high++;
                }
            }
            catch (Exception e) {
                Console.WriteLine("Err");
            }
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
