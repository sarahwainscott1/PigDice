using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice {
    internal class PigDiceGame {

        private Random rnd = new Random();

        private int RollDie() {
            return rnd.Next(1, 7);
        }

        public int Play() {
            var score = 0;
            var roll = RollDie();
            while (roll != 1) {
                score += roll;
                roll= RollDie();
            }
            return score;
        }
    }

}
