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
            const int snake = 2;const int ladder = 1;
            int position = 0;

            Random random = new Random();
            int rollDice = random.Next(1, 7);
            int option = random.Next(0, 3);
            switch (option)
            {
                case ladder :
                    Console.WriteLine("Ladder");
                    position += rollDice;
                    break;
                case snake :
                    Console.WriteLine("Snake");
                    if(position - rollDice < 0)
                    {
                        position = 0;
                    }
                    else
                    {
                        position -= rollDice;
                    }
                    break;
                default:
                    break;
            }          
            Console.WriteLine("Value of Dice is " + rollDice);           
            Console.WriteLine("Player is at " + position);
        }
    }
}
