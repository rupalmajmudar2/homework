using System;
using System.Collections.Generic;
using System.Text;

namespace RmHomeworkProject.problems {
    /*
     * Your function takes an array of integers (arr), and an integer (x). You need to find the position in arr that splits the array in two, 
     * where one side has as many occurrences of x as the other side has occurrences of any number but x. 
     * So, given an array like this: [5, 5, 2, 3, 5, 1, 6] and x being "5", the function should return "4" 
     * (Position 4, holding the number "3" above is the point where you have 2 5's on the one side, and two "not fives" on the other).
     */
    class Grouping {
        public int solution(int[] A, int X) {
            int[] CumulativeXs = new int[A.Length];
            int[] CumulativeNonXs = new int[A.Length];

            int totalXs = 0;
            int totalNonXs = 0;
            for (int i = 0; i < A.Length; i++) {
                if (A[i] == X) {
                    CumulativeXs[i] = ++totalXs;
                    CumulativeNonXs[i] = totalNonXs; //same as before
                }
                else {
                    CumulativeXs[i] = totalXs; //same as before
                    CumulativeNonXs[i] = ++totalNonXs;
                }
            }

            //Traverse both arrays, find the _position_ where they equal
            for (int i = 0; i < A.Length; i++) {
                int numXsTillHere = CumulativeXs[i];
                int numNonXsOnOtherSide = CumulativeNonXs[A.Length - 1] - CumulativeNonXs[A.Length - 1];
                if ( CumulativeXs[i] == CumulativeNonXs[i] ) {
                    return (i+1); //index 0 is 1st position!
                }
            }

            return -1;
        }
    }
}
