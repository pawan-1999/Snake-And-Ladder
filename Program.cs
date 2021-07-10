using System;
using System.Collections.Generic;
using System.Text;

namespace UC_1_SnakeAndLadderPlayedAtPosition0
{
    class UC_5_ExactWinningPosition
    {
       ublic const int POSITION = 0;
        public const int WINNING_POSITION = 100;
        public void exactWinPosition()
        {
            int position = 0;
            Random random = new Random();
            Random random1 = new Random();
            Console.WriteLine("Snake And Ladder Game ");
            while (position != WINNING_POSITION)
            {
                int player = random.Next(0, 6) +1;
                Console.WriteLine("Outcomes is : " +player);
                int option = random1.Next(1, 3) + 1;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Current position is: " +position);
                        Console.WriteLine("You stay in same position: " +position);
                        
                        break;
                    case 2:
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
                    case 3:
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

