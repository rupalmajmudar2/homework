using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RmHomeworkProject.problems {
    public class TowersOfHanoi {
        public static void Main(String[] args) {
            char startPeg = 'A'; // start tower in output
            char endPeg = 'C'; // end tower in output
            char tempPeg = 'B'; // temporary tower in output
            int totalDisks = 5; // number of disks
            string prn = "";
            prn = solveTowers(totalDisks, startPeg, endPeg, tempPeg, prn);
        }

        private static string solveTowers(int n, char startPeg, char endPeg, char tempPeg, string prn) {
            
            if (n > 0) {
                solveTowers(n - 1, startPeg, tempPeg, endPeg, prn);
                Debug.WriteLine( "Move disk from " + startPeg + ' ' + endPeg );
                solveTowers(n - 1, tempPeg, endPeg, startPeg, prn);
            }
            return prn;
        }

    }
}
