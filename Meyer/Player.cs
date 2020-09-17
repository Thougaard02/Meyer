using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyer
{


    class Player
    {

        public DiceRoll dice = new DiceRoll();
        public string[] playerNames;
        public void PlayerSelection()
        {
            //Create players
            Console.WriteLine("Enter the numbers of players 2+ ");

            int amount = Int32.Parse(Console.ReadLine());

            if (amount <= 1)
            {
                Console.WriteLine("Minimum two players!");
            }
            else
            {
                playerNames = new string[amount];
                for (int i = 0; i < playerNames.Length; i++)
                {
                    Console.WriteLine("Insert player " + (i + 1) + " name");
                    playerNames[i] = Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public string result;
        public void PlayerTurn(int playerIndex)
        {
            Console.WriteLine(playerNames[playerIndex] + " press any key to roll");
            Console.ReadKey();
            result = dice.DiceGenerator();
            Console.ReadKey();
            Console.Clear();
        }
        public void PlayerChoice()
        {
            StartGame();
            while (true)
            {
                for (int i = 0; i < playerNames.Length; i++)
                {
                    PlayerTurn(i);
                    //i = 0
                    //playerNe
                    if (i == +i)
                    {
                        //Writes player 1
                        Console.WriteLine(playerNames[i] + " What are you going to do");

                        Console.WriteLine("Press 1 to trust!");
                        Console.WriteLine("Press 2 to not believe");
                    }
                    //Prints player bo out first round i = 2-1 
                    //Writes all players expect player 1                    
                    int userInput = Int32.Parse(Console.ReadLine());

                    //Trykker man 2 skal man kunne se hvad den tidligere slog og derefter slå terningen
                    if (userInput == 1)
                    {
                        Console.Clear();
                    }
                    else if (userInput == 2)
                    {
                        //prints i = mar
                        Console.WriteLine(playerNames[i] + " slog" + result);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }

        public void StartGame()
        {
            Console.WriteLine("Press any key to start the game!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
