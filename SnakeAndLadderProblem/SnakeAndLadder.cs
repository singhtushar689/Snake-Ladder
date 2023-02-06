using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeAndLadder
    {
        public void Game()
        {
            int initialPos = 0;
            Console.WriteLine("Player is at " + initialPos);

            Random random = new Random();
            int rollDice = random.Next(1, 7);
            Console.WriteLine("The Roll dice is " + rollDice);
        }
    }
}
