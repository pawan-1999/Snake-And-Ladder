using System;

namespace UC_1_SnakeAndLadderPlayedAtPosition0
{
    class Program
    {
        static void Main(string[] args)
        {
            const int POSITION = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UC_1_SnakeAndLadderPlayedAtPosition0
{
    class UC_2_DieRolled
    {
        public void playerRolledDie()
        {
            Console.WriteLine("Snake And Ladder");
            Random random = new Random();
            int player = random.Next(0, 7);
            Console.WriteLine("Outcome is : "+player);
        }
    }
}

