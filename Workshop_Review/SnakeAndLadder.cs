using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Review
{
    public class SnakeAndLadder
    {
        int position = 0;
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        public int DieRoll()
        {
            Random random = new Random();
            int diePoistion = random.Next(1, 7);
            return diePoistion;
        }

        public void Game()
        {
            Random rand = new Random();
            int option = rand.Next(0, 3);
            switch (option)
            {
                case 0:
                    break;
                case SNAKE:
                    this.position -= this.DieRoll();
                         break;
                case LADDER:
                    this.position += this.DieRoll();
                        break;  
            }
            Console.WriteLine(this.position);

        }
    }
}
