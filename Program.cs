using System;
using System.Collections.Generic;
using System.Text;

namespace UC_1_SnakeAndLadderPlayedAtPosition0
{
    class UC_5_ExactWinningPosition
    {
        public const int POSITION = 0;
        public const int WINNING_POSITION = 100;
        public void exactWinPosition()
        {
            int position = 0;
            Console.WriteLine("Snake And Ladder Game ");
            while (position != WINNING_POSITION)
            {
                Random random = new Random();
                int player = random.Next(0, 7);
                Console.WriteLine("Outcomes is : " +player);
                Random random1 = new Random();
                int option = random1.Next(0, 3);
                switch (position)
                {
                    case 0:
                        Console.WriteLine("Current position is: " +position);
                        Console.WriteLine("You stay in same position: " +position);
                        
                        break;
                    case 1:
                        Console.WriteLine("Your current position is:" +position);
                        Console.WriteLine("You encountered a ladder");
                        if ((position+player) > 100)
                        {
                            Console.WriteLine("Current position is:" +position);
                        }
                        else
                        {
                            position = position + player;
                            Console.WriteLine("Player ladder moves ahead:" +position);
                        }
                        break;
                    case 2:
                        Console.WriteLine("You encountered a Snake");
                        Console.WriteLine("Current position is:" +position);
                        if (position < 0)
                        {
                            Console.WriteLine("Player snake moves bheind:" +POSITION);
                            position = POSITION;
                        }
                        else
                        {
                            position = position - player;
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
           	       UC_5_ExactWinningPosition obj3 = new UC_5_ExactWinningPosition();
                   obj3.exactWinPosition();
		    } 

