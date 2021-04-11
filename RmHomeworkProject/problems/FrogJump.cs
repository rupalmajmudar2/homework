using System;
using System.Collections.Generic;
using System.Text;

namespace RmHomeworkProject.problems {
    class FrogJump {

        //Start position, end, jump
        public int solution(int X, int Y, int D) {
            int distance = Y - X;
            int remainder = distance % D;
            int numJumps = (distance - remainder) / D;
            if (remainder == 0) return numJumps;
            else return numJumps + 1;
        }
    }
}
