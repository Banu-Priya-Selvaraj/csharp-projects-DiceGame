using System;

namespace Dicegame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerNumber;
            int enemyNumber;

            int playerPoints=0;
            int enemyPoints = 0;


            Random random = new Random();
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey();
                playerNumber = random.Next(1, 7);
                Console.WriteLine("Heyy!You rolled a " + playerNumber);

                Console.WriteLine("......");
                System.Threading.Thread.Sleep(1000);

                enemyNumber = random.Next(1, 7);
                Console.WriteLine("Your Enemy rolled a " + enemyNumber);

                if(playerNumber > enemyNumber)
                {
                    playerPoints++;
                    Console.WriteLine("Player Wins this  Round!");
                }
                else if (playerNumber < enemyNumber)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy Wins this  Round!");
                }
                else 
                {
                   
                    Console.WriteLine("And it's a Draw!");
                }
                Console.WriteLine("The score is now-Player:" + playerPoints + ".Enemy:" + enemyPoints + ".");
                Console.WriteLine();
            }
            if(playerPoints>enemyPoints)
            {
                Console.WriteLine("Finally You Win!!");

            }
            else if(playerPoints<enemyPoints)
            {
                Console.WriteLine("Finally You Lose!!");
            }
            else
            {
                Console.WriteLine("Finally It's a Draw!!");
            }
            Console.ReadKey();
                



            
        }
    }
}
