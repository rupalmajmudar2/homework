using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

/*
 *  Longest Substring Without Repeating Characters
Medium

Given a string s, find the length of the longest substring without repeating characters.
Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/
namespace RmHomeworkProject.problems {
    class TestLongestNonRepeatingSubstring {
        private List<MySubstring> allSubstrings = new List<MySubstring>();

        [Test]
        public void Test() {
            string s = "abcabcdbb";
            int longestSubstring = getLongestSubstring(s);
            Assert.AreEqual(4, longestSubstring);

            s = "pwwkew";
            longestSubstring = getLongestSubstring(s);
            Assert.AreEqual(3, longestSubstring);
        }

        /*
         * Algo:
         * read each char
         * In a Map, store List<MyString> objects { private string _finalSubstring, Map char => count } 
         * If count > 1 start a new MyString
         * .
         *  * At the end, compare all the _finalSubstring objects.
         *  .
         * Optimizn: track the maxlen MyString so we don't need to go thru all the objects again.
         * .

         */
        public int getLongestSubstring(string s) {
            int maxLen = 0;
            MySubstring maxLenSubstringObj = null;

            char[] chars = s.ToCharArray();
            MySubstring substringObj = new MySubstring();
            allSubstrings.Add(substringObj); //not really reqd

            foreach (char c in chars) {
                if (substringObj.checkChar(c) == false) {
                    int len = substringObj.getStrLen();
                    if (len > maxLen) {
                        maxLen = len;
                        maxLenSubstringObj = substringObj;
                    }

                    //And start a new obj
                    substringObj = new MySubstring();
                    allSubstrings.Add(substringObj); //not really reqd
                    substringObj.checkChar(c); //Add the dup as the first item in the fresh list!
                }
            }

            return maxLen;
        }
    }

    public class MySubstring {
        public Dictionary<char, int> charCountTable = new Dictionary<char, int>();
        public StringBuilder strBuilder = new StringBuilder();
        public bool checkChar(char c) {
            if (charCountTable.ContainsKey(c)) {
                //already there. So a duplicate char has come in. Stop here!
                return false;
            }

            charCountTable[c] = 1;
            strBuilder.Append(c);
            return true;
        }

        public int getStrLen() {
            return strBuilder.Length;
        }
    }
}
