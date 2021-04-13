using System;
using System.Collections.Generic;
using System.Text;

namespace RmHomeworkProject.problems {
    class TopTal1 {
        public int solution(int[] A) {
            return -1;
        }
    }

    class Result {

        /*
         * Complete the 'fizzBuzz' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void fizzBuzz(int n) {
            for (int i = 1; i <= n; i++) {
                if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine("FizzBuzz");
                if ((i % 3 == 0) && (i % 5 != 0)) Console.WriteLine("Fizz");
                if ((i % 3 != 0) && (i % 5 == 0)) Console.WriteLine("Buzz");
                if ((i % 3 != 0) && (i % 5 != 0)) Console.WriteLine(i);
            }
        }

    }
}
