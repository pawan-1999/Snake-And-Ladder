using System;
using System.Collections.Generic;
using System.Text;

namespace UC_1_SnakeAndLadderPlayedAtPosition0
{
    class UC_4_WinningPosition
    {
        public const int POSITION = 0;
        public void winPosition()
        {
            int position = 0, ladderCount = 0, snakeCount = 0;
            Console.WriteLine("Snake And Ladeer Game ");
            Random random = new Random();
            int player = random.Next(0, 7);
            Console.WriteLine("Outcome is : " + player);
            Random random1 = new Random();
            int option = random1.Next(0, 3);
            //Winning Condition 
            while (position!=100)
            {
                switch (option)
                {
                    case 0:
                        Console.WriteLine("your current position : " +position);
                        Console.WriteLine("you stay in same position : " +position);
                        break;
                    case 1:
                        ladderCount++;
                        Console.WriteLine("current poition is : " +position);
                        position = position + player;
                        Console.WriteLine("Player ladder moves ahead : " +position );
                        break;
                    case 2:
                        snakeCount++;
                        Console.WriteLine("Current position is : " +position);
                        position = position - player;
                        if (position < 0)
                        {
                            Console.WriteLine("Player snake move behind : " + POSITION);
                        }
                        else
                        {
                            Console.WriteLine("Player moves behind :" +position);
                        }
                        break;
                }

            }
        }
    }
}

  static void Main(string[] args)
        {
            const int POSITION = 0;
            UC_4_WinningPosition obj2 = new UC_4_WinningPosition();
            obj2.winPosition();
        }
