using System;
using System.Collections.Generic;
using System.Text;

namespace RmHomeworkProject.problems {
    public class TowersOfHanoi {
        public static void Main(String[] args) {
            char startPeg = 'A'; // start tower in output
            char endPeg = 'C'; // end tower in output
            char tempPeg = 'B'; // temporary tower in output
            int totalDisks = 3; // number of disks
            string prn = "";
            solveTowers(totalDisks, startPeg, endPeg, tempPeg, prn);
        }

        private static string solveTowers(int n, char startPeg, char endPeg, char tempPeg, string prn) {
            
            if (n > 0) {
                solveTowers(n - 1, startPeg, tempPeg, endPeg, prn);
                Console.WriteLine("Move disk from " + startPeg + ' ' + endPeg);
                prn += "Move disk from " + startPeg + ' ' + endPeg;
                prn = solveTowers(n - 1, tempPeg, endPeg, startPeg, prn);

            }
            return prn;
        }

    }
}
